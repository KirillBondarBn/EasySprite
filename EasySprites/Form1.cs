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
        Bitmap toolsBmp;
        Graphics gr;
        Pen pen;
        Brush brush = new SolidBrush(Color.Black);
        int MouseX, MouseY;

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
            gr = Graphics.FromImage(toolsBmp);
            pen = new Pen(brush, 5);

            this.BackColor = ColorTranslator.FromHtml("#202230");
            toolsBox.BackColor = ColorTranslator.FromHtml("#282a3b");
            menuStrip1.BackColor = ColorTranslator.FromHtml("#282a3b");
            fileToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#282a3b");
            openCtrlOToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#282a3b");
            saveCtrlSToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#282a3b");
            saveToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#282a3b");
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.Black;
        }

        private void fileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.White;
        }

        int x, y;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            brush = new SolidBrush(mainColor.BackColor);
            if (MouseX >= (MousePosition.X - this.Location.X - mainImage.Location.X - 8) + 5 
            ||  MouseX <= (MousePosition.X - this.Location.X - mainImage.Location.X - 8) - 5)
                MouseX = MousePosition.X - this.Location.X - mainImage.Location.X - 8;

            if (MouseY >= (MousePosition.Y - this.Location.Y - mainImage.Location.Y - 31) + 5
            ||  MouseY <= (MousePosition.Y - this.Location.Y - mainImage.Location.Y - 31) - 5)
                MouseY = MousePosition.Y - this.Location.Y - mainImage.Location.Y - 31;

            x = MouseX;
            y = MouseY;

            gr.Clear(Color.White);

            gr.FillRectangle(brush, x, y, 15, 15);

            mainImage.Image = toolsBmp;
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
        }
    }
}
