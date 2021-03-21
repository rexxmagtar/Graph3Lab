using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var dialog = openFileDialog1.ShowDialog();


            if (dialog == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);

                pictureBox1.Image = img;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DialateButton_Click(object sender, EventArgs e)
        {


            Image img = pictureBox1.Image;

            Bitmap bitmap = (Bitmap)img;

            bitmap = bitmap.DilateAndErodeFilter((int)matrixSizeUpAndDown.Value, BitmapExtensions.MorphologyType.Dilation,blueCheckBox.Checked, greenCheckbox.Checked, redCheckBox.Checked);

            pictureBox1.Image = bitmap;
        }

        private void EroseButton_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;

            Bitmap bitmap = (Bitmap)img;

            bitmap = bitmap.DilateAndErodeFilter((int)matrixSizeUpAndDown.Value, BitmapExtensions.MorphologyType.Erosion, blueCheckBox.Checked, greenCheckbox.Checked, redCheckBox.Checked);

            pictureBox1.Image = bitmap;
        }

        private void OpenMorphologyButton_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;

            Bitmap bitmap = (Bitmap)img;

            bitmap = bitmap.OpenMorphologyFilter((int)matrixSizeUpAndDown.Value, blueCheckBox.Checked, greenCheckbox.Checked, redCheckBox.Checked);

            pictureBox1.Image = bitmap;
        }

        private void CloseMorphologyButton_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;

            Bitmap bitmap = (Bitmap)img;

            bitmap = bitmap.CloseMorphologyFilter((int)matrixSizeUpAndDown.Value, blueCheckBox.Checked, greenCheckbox.Checked, redCheckBox.Checked);

            pictureBox1.Image = bitmap;
        }

        private void LinearConstrantButton_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;

            Bitmap bitmap = (Bitmap)img;

            bitmap = bitmap.LinearContrast(0, 255);

            pictureBox1.Image = bitmap;
        }
    }
}