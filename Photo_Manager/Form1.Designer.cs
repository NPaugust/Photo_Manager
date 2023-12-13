namespace Photo_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button8 = new Button();
            button9 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(125, 13);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1176, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "";
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuText;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(20, 416);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(219, 80);
            button1.TabIndex = 1;
            button1.Text = "Black and White";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkOrchid;
            button2.Location = new Point(588, 416);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(219, 80);
            button2.TabIndex = 1;
            button2.Text = "Negative";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LawnGreen;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Desktop;
            button3.Location = new Point(1153, 416);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(219, 80);
            button3.TabIndex = 1;
            button3.Text = "Light Green";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrchid;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Cyan;
            button4.Location = new Point(304, 416);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(219, 80);
            button4.TabIndex = 1;
            button4.Text = "Neon";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Firebrick;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(875, 416);
            button5.Margin = new Padding(4, 4, 4, 4);
            button5.Name = "button5";
            button5.Size = new Size(219, 80);
            button5.TabIndex = 1;
            button5.Text = "Magenta";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleGreen;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Arial", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(896, 598);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(198, 39);
            button6.TabIndex = 1;
            button6.Text = "add tag";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.WindowFrame;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button7.ForeColor = Color.Cyan;
            button7.Location = new Point(1153, 534);
            button7.Margin = new Padding(4, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(219, 80);
            button7.TabIndex = 1;
            button7.Text = "Return";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(125, 636);
            trackBar1.Margin = new Padding(4, 4, 4, 4);
            trackBar1.Maximum = 35;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(934, 69);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 5;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(125, 701);
            trackBar2.Margin = new Padding(4, 4, 4, 4);
            trackBar2.Maximum = 35;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(934, 69);
            trackBar2.TabIndex = 2;
            trackBar2.Value = 15;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(125, 754);
            trackBar3.Margin = new Padding(4, 4, 4, 4);
            trackBar3.Maximum = 35;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(934, 69);
            trackBar3.TabIndex = 2;
            trackBar3.Value = 25;
            trackBar3.ValueChanged += trackBar3_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(20, 625);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 40);
            label1.TabIndex = 3;
            label1.Text = "Red";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.PaleGreen;
            label2.Location = new Point(13, 686);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 40);
            label2.TabIndex = 3;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Diagram;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(20, 742);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 40);
            label3.TabIndex = 3;
            label3.Text = "Blue";
            label3.Click += label3_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSlateGray;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button8.ForeColor = Color.Cyan;
            button8.Location = new Point(1153, 636);
            button8.Margin = new Padding(4, 4, 4, 4);
            button8.Name = "button8";
            button8.Size = new Size(219, 82);
            button8.TabIndex = 1;
            button8.Text = "Save picture";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.MediumPurple;
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button9.ForeColor = Color.Cyan;
            button9.Location = new Point(1153, 736);
            button9.Margin = new Padding(4, 4, 4, 4);
            button9.Name = "button9";
            button9.Size = new Size(219, 82);
            button9.TabIndex = 1;
            button9.Text = "Explode";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Highlight;
            textBox1.Location = new Point(669, 547);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your tag";
            textBox1.Size = new Size(425, 27);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1415, 831);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Photo Manager";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Label label1;
        private Label label2;
        private Button button8;
        private Button button9;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        internal Label label3;
        private TextBox textBox1;
    }
}