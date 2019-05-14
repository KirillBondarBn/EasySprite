namespace EasySprites
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainColor = new System.Windows.Forms.PictureBox();
            this.secondColor = new System.Windows.Forms.PictureBox();
            this.penTool = new System.Windows.Forms.PictureBox();
            this.mainImage = new System.Windows.Forms.PictureBox();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            this.ColorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCtrlOToolStripMenuItem,
            this.saveCtrlSToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Fedra Sans Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.fileToolStripMenuItem_DropDownClosed);
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openCtrlOToolStripMenuItem
            // 
            this.openCtrlOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openCtrlOToolStripMenuItem.Name = "openCtrlOToolStripMenuItem";
            this.openCtrlOToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openCtrlOToolStripMenuItem.Text = "Open            Ctrl + O";
            this.openCtrlOToolStripMenuItem.Click += new System.EventHandler(this.openCtrlOToolStripMenuItem_Click);
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveCtrlSToolStripMenuItem.Text = "New              Ctrl + N";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveToolStripMenuItem.Text = "Save              Ctrl + S";
            // 
            // toolsBox
            // 
            this.toolsBox.BackColor = System.Drawing.SystemColors.Control;
            this.toolsBox.Controls.Add(this.pictureBox1);
            this.toolsBox.Controls.Add(this.pictureBox2);
            this.toolsBox.Controls.Add(this.mainColor);
            this.toolsBox.Controls.Add(this.secondColor);
            this.toolsBox.Controls.Add(this.penTool);
            this.toolsBox.Font = new System.Drawing.Font("Fedra Sans Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolsBox.ForeColor = System.Drawing.Color.White;
            this.toolsBox.Location = new System.Drawing.Point(742, 38);
            this.toolsBox.Name = "toolsBox";
            this.toolsBox.Size = new System.Drawing.Size(53, 400);
            this.toolsBox.TabIndex = 2;
            this.toolsBox.TabStop = false;
            this.toolsBox.Text = "Tools";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::EasySprites.Properties.Resources.refresh_button;
            this.pictureBox1.Location = new System.Drawing.Point(32, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::EasySprites.Properties.Resources.icons8_settings_480;
            this.pictureBox2.Location = new System.Drawing.Point(11, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // mainColor
            // 
            this.mainColor.BackColor = System.Drawing.Color.Maroon;
            this.mainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainColor.Location = new System.Drawing.Point(6, 360);
            this.mainColor.Name = "mainColor";
            this.mainColor.Size = new System.Drawing.Size(25, 25);
            this.mainColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainColor.TabIndex = 2;
            this.mainColor.TabStop = false;
            this.mainColor.Click += new System.EventHandler(this.mainColor_Click);
            // 
            // secondColor
            // 
            this.secondColor.BackColor = System.Drawing.Color.White;
            this.secondColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondColor.Location = new System.Drawing.Point(17, 369);
            this.secondColor.Name = "secondColor";
            this.secondColor.Size = new System.Drawing.Size(25, 25);
            this.secondColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondColor.TabIndex = 1;
            this.secondColor.TabStop = false;
            // 
            // penTool
            // 
            this.penTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.penTool.Image = global::EasySprites.Properties.Resources.edit;
            this.penTool.Location = new System.Drawing.Point(11, 20);
            this.penTool.Name = "penTool";
            this.penTool.Size = new System.Drawing.Size(32, 32);
            this.penTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.penTool.TabIndex = 0;
            this.penTool.TabStop = false;
            // 
            // mainImage
            // 
            this.mainImage.BackColor = System.Drawing.Color.White;
            this.mainImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainImage.Location = new System.Drawing.Point(12, 38);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(430, 399);
            this.mainImage.TabIndex = 1;
            this.mainImage.TabStop = false;
            this.mainImage.Click += new System.EventHandler(this.mainImage_Click);
            this.mainImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainImage_MouseDown);
            this.mainImage.MouseEnter += new System.EventHandler(this.mainImage_MouseEnter);
            this.mainImage.MouseLeave += new System.EventHandler(this.mainImage_MouseLeave);
            this.mainImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mainImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainImage_MouseUp);
            // 
            // ColorBox
            // 
            this.ColorBox.Controls.Add(this.textBox3);
            this.ColorBox.Controls.Add(this.textBox2);
            this.ColorBox.Controls.Add(this.textBox1);
            this.ColorBox.Controls.Add(this.label3);
            this.ColorBox.Controls.Add(this.label2);
            this.ColorBox.Controls.Add(this.label1);
            this.ColorBox.Controls.Add(this.trackBar3);
            this.ColorBox.Controls.Add(this.trackBar2);
            this.ColorBox.Controls.Add(this.trackBar1);
            this.ColorBox.Font = new System.Drawing.Font("Fedra Sans Pro Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorBox.ForeColor = System.Drawing.Color.White;
            this.ColorBox.Location = new System.Drawing.Point(536, 218);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(200, 220);
            this.ColorBox.TabIndex = 3;
            this.ColorBox.TabStop = false;
            this.ColorBox.Text = "Color";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 143);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 23);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(6, 167);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 23);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.AutoSize = false;
            this.trackBar3.Location = new System.Drawing.Point(6, 191);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 23);
            this.trackBar3.TabIndex = 2;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(114, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(114, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(114, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(134, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(134, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(27, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(134, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 23);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.toolsBox);
            this.Controls.Add(this.mainImage);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EasySprite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            this.ColorBox.ResumeLayout(false);
            this.ColorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.GroupBox toolsBox;
        private System.Windows.Forms.PictureBox penTool;
        private System.Windows.Forms.PictureBox mainColor;
        private System.Windows.Forms.PictureBox secondColor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

