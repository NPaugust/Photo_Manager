using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Photo_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image file;

        Boolean opened = false;

        private void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        }

        private void saveImage()
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
            else { MessageBox.Show("No image loaded, first upload image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void reload()
        {
            if (!opened)
            {
                /*MessageBox.Show("Open an Image then apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = file;
                    opened = true;
                }
            }
        }

        private void filter1()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                    new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                    new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void filter2()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[] {-1, 0, 0, 0, 0},
                    new float[] {0, -1, 0, 0, 0},
                    new float[] {0, 0, -1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {1, 1, 1, 0, 1},
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void filter3()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[] {.393f, .349f+0.5f, .272f, 0, 0},
                    new float[] {.369f+0.3f, .686f, .534f, 0, 0},
                    new float[] {.189f, .168f, .131f+0.5f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void filter4()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[] {.393f, .349f, .100f, 0, 0},
                    new float[] {.369f, .686f, .800f, 0, 0},
                    new float[] {.189f, .168f, .131f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void filter5()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[] {2, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {.2f, .2f, .2f, 0, 1},
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void trackBar()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[] {1+(trackBar1.Value*0.01f), 0, 0, 0, 0},
                    new float[] {0, 1+(trackBar2.Value*0.01f), 0, 0, 0},
                    new float[] {0, 0, 1+(trackBar3.Value*0.01f), 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }


        private void addWatermark()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    string watermarkText = textBox1.Text;
                    Font watermarkFont = new Font("Arial", 40);
                    Brush watermarkBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 255));

                    float x = (pictureBox1.Image.Width - g.MeasureString(watermarkText, watermarkFont).Width);
                    float y = (pictureBox1.Image.Height - g.MeasureString(watermarkText, watermarkFont).Height);

                    g.DrawString(watermarkText, watermarkFont, watermarkBrush, x, y);
                }
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload();
            filter1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reload();
            filter2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reload();
            filter3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reload();
            filter4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reload();
            filter5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addWatermark();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                trackBar1.Value = 0;
                trackBar2.Value = 0;
                trackBar3.Value = 0;
                reload();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            reload();
            trackBar();
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            reload();
            trackBar();
        }
        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            reload();
            trackBar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}