using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasySprites
{
    public partial class Form1 : Form
    {
        Bitmap toolsBmp, mainBmp;
        Graphics gr, midGr;
        Pen pen;
        Brush brush = new SolidBrush(Color.Black);
        int MouseX, MouseY;
        bool draw = false, change = true;
        string enabled = "pen";
        int size = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "*.bmp, *.jpg, *.png|*.bmp;*.jpg;*.png";
            opf.CheckFileExists = true;
            opf.CheckPathExists = true;
            opf.Title = "Open";
            if (opf.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolsBmp = new Bitmap(mainImage.Width, mainImage.Height);
            mainBmp = new Bitmap(mainImage.Width, mainImage.Height);
            gr = Graphics.FromImage(toolsBmp);
            midGr = Graphics.FromImage(mainBmp);
            pen = new Pen(brush, 5);

            textBox1.Text = mainColor.BackColor.R.ToString();
            textBox2.Text = mainColor.BackColor.G.ToString();
            textBox3.Text = mainColor.BackColor.B.ToString();

            this.BackColor = ColorTranslator.FromHtml("#202230");

            toolsBox.BackColor = ColorTranslator.FromHtml("#282a3b");
            ColorBox.BackColor = ColorTranslator.FromHtml("#282a3b");

            button1.BackColor = ColorTranslator.FromHtml("#e41d23");

            menuStrip1.BackColor = ColorTranslator.FromHtml("#282a3b");
            fileToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#282a3b");
            openCtrlOToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#282a3b");
            saveCtrlSToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#282a3b");
            saveToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#282a3b");

            label1.ForeColor = Color.FromArgb(255, 137, 63, 69);
            label2.ForeColor = Color.FromArgb(255, 59, 176, 143);
            label3.ForeColor = Color.FromArgb(255, 93, 118, 203);

            trackBar1.BackColor = Color.FromArgb(255, 137, 63, 69);
            trackBar2.BackColor = Color.FromArgb(255, 59, 176, 143);
            trackBar3.BackColor = Color.FromArgb(255, 93, 118, 203);

            trackBar3_Scroll(sender, e);
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.Black;
        }

        private void fileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.White;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x, y;
            Color clr = Color.FromArgb(255, mainColor.BackColor.R, mainColor.BackColor.G, mainColor.BackColor.B);
            brush = new SolidBrush(clr);

            if (MouseX >= (MousePosition.X - this.Location.X - mainImage.Location.X - 8) + 4)  MouseX -= 4;
            if (MouseX <= (MousePosition.X - this.Location.X - mainImage.Location.X - 8) - 4)  MouseX += 4;
            if (MouseY >= (MousePosition.Y - this.Location.Y - mainImage.Location.Y - 31) + 4) MouseY -= 4;
            if (MouseY <= (MousePosition.Y - this.Location.Y - mainImage.Location.Y - 31) - 4) MouseY += 4;

            x = MouseX;
            y = MouseY;

            gr.Clear(Color.FromArgb(0, 0, 0, 0));


            switch (enabled)
            {
                case "pen": pen_Tool(brush, x, y); break;
            }

            mainImage.Image = toolsBmp;
            mainImage.BackgroundImage = mainBmp;
        }

        public void pen_Tool(Brush brush, int x, int y)
        {
            pen = new Pen(Color.Black);
            if(draw)
            {
                midGr.FillRectangle(brush, x, y, size, size);
                gr.FillRectangle(brush, x, y, size, size);
                gr.DrawRectangle(pen, x, y, size - 1, size - 1);
            }
            else
            {
                gr.FillRectangle(brush, x, y, size, size);
                gr.DrawRectangle(pen, x, y, size - 1, size - 1);
            }
        }

        private void mainImage_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void mainImage_Click(object sender, EventArgs e)
        {

            int x, y;
            if (MouseX >= (MousePosition.X - this.Location.X - mainImage.Location.X - 8) + 5
            || MouseX <= (MousePosition.X - this.Location.X - mainImage.Location.X - 8) - 5)
                MouseX = MousePosition.X - this.Location.X - mainImage.Location.X - 8;

            if (MouseY >= (MousePosition.Y - this.Location.Y - mainImage.Location.Y - 31) + 5
            || MouseY <= (MousePosition.Y - this.Location.Y - mainImage.Location.Y - 31) - 5)
                MouseY = MousePosition.Y - this.Location.Y - mainImage.Location.Y - 31;

            x = MouseX;
            y = MouseY;

            gr.Clear(Color.FromArgb(0, 0, 0, 0));

            switch(enabled)
            {
                case "pen": pen_Tool(brush, x, y); break;
            }


            mainImage.Image = toolsBmp;
            mainImage.BackgroundImage = mainBmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Color clr = secondColor.BackColor;
            secondColor.BackColor = mainColor.BackColor;
            mainColor.BackColor = clr;

            change = false;
            textBox1.Text = mainColor.BackColor.R.ToString();
            textBox2.Text = mainColor.BackColor.G.ToString();
            textBox3.Text = mainColor.BackColor.B.ToString();

            trackBar1.Value = mainColor.BackColor.R;
            trackBar2.Value = mainColor.BackColor.G;
            trackBar3.Value = mainColor.BackColor.B;
            change = true;

            trackBar3_Scroll(sender, e);
        }

        private void mainColor_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            byte r = Convert.ToByte(trackBar1.Value),
               g = Convert.ToByte(trackBar2.Value),
               b = Convert.ToByte(trackBar3.Value);

            mainColor.BackColor = Color.FromArgb(255, r, g, b);

            textBox1.Text = trackBar1.Value.ToString();
            textBox2.Text = trackBar2.Value.ToString();
            textBox3.Text = trackBar3.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(change)
            {
                try
                {
                    int num = Convert.ToInt32(textBox1.Text);
                    if (num > 255) textBox1.Text = "255";
                    trackBar1.Value = num;
                    trackBar3_Scroll(sender, e);
                }
                catch { }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (change)
            {
                try
                {
                    int num = Convert.ToInt32(textBox2.Text);
                    if (num > 255) textBox2.Text = "255";
                    trackBar2.Value = num;
                    trackBar3_Scroll(sender, e);
                }
                catch { }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(change)
            {
                try
                {
                    int num = Convert.ToInt32(textBox3.Text);
                    if (num > 255) textBox2.Text = "255";
                    trackBar3.Value = num;
                    trackBar3_Scroll(sender, e);
                }
                catch { }
            }
        }
        public void clearEnab()
        {
            penTool.BorderStyle = BorderStyle.None;
            rubberTool.BorderStyle = BorderStyle.None;
        }
        private void penTool_MouseEnter(object sender, EventArgs e)
        {
            if(enabled != "pen")
            {
                clearEnab();
                penTool.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void penTool_Click(object sender, EventArgs e)
        {
            enabled = "pen";
            penTool.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Control ctr = new Control(PictureBox);
        }

        private void penTool_MouseLeave(object sender, EventArgs e)
        {
            if (enabled != "pen") penTool.BorderStyle = BorderStyle.None;
        }

        private void mainImage_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
        }

        private void mainImage_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
            MouseX = MousePosition.X - this.Location.X - mainImage.Location.X - 8;
            MouseY = MousePosition.Y - this.Location.Y - mainImage.Location.Y - 31;
        }

        private void mainImage_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
            gr.Clear(Color.FromArgb(0, 0, 0, 0));
        }
    }
}
