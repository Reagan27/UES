using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video.FFMPEG;
  

namespace UES
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

        public void CreateVideoFromImages(string[] imagePaths, string outputVideoPath)
        {
            int width = 1280;
            int height = 720;  
            int frameRate = 10; 

            VideoFileWriter writer = new VideoFileWriter();
            writer.Open(outputVideoPath, width, height, frameRate, VideoCodec.MPEG4);

            foreach (var imagePath in imagePaths)
            {
                Bitmap image = new Bitmap(imagePath);
                writer.WriteVideoFrame(image);
                image.Dispose();
            }

            writer.Close();
        }
    }
}
