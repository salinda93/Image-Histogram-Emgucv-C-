using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguCv_Tutorial_06
{
    public partial class Form1 : Form
    {
        Image<Bgr, Byte> InputImage;
        Image<Gray, Byte> R;
        Image<Gray, Byte> G;
        Image<Gray, Byte> B;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button01_Click(object sender, EventArgs e)
        {
            String FileName = "D:\\Visual Studio 2019 workspace\\6a.png";
            InputImage = new Image<Bgr, byte>(FileName);

            B = InputImage[0];
            G = InputImage[1];
            R = InputImage[2];

            imageBox1.Image = R;
            imageBox2.Image = G;
            imageBox3.Image = B;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InputImage == null)
            {
                MessageBox.Show("Please select an Image");
                return;
            }

            histogramBox1.ClearHistogram();
            histogramBox2.ClearHistogram();
            histogramBox3.ClearHistogram();

            histogramBox1.GenerateHistograms(R, 256);
            histogramBox2.GenerateHistograms(G, 256);
            histogramBox3.GenerateHistograms(B, 256);

            histogramBox1.Refresh();
            histogramBox2.Refresh();
            histogramBox3.Refresh();
        }
    }
}
