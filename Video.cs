using Emgu.CV.CvEnum;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace Proiect
{
    internal class Video
    {
        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;
        PictureBox pictureBox;
        List <Mat> videoList= new List<Mat>();
        public void loadVideo(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
               
                TotalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                FrameNo = 1;
                this.frameVideo();
                pictureBox.Image = videoList[0].ToBitmap();
            }

        }
        public void frameVideo()
        {
            int frame = 0;
            while(frame < TotalFrame-1)
            {
                Mat mat = new Mat();
                this.capture.Read(mat); //capture e un fel de stiva in care punem mat-uri
                this.videoList.Add(mat);
                frame++;
            }
        }

        private async void ReadAllFrames()
        {

            Mat m = new Mat();
            while ( FrameNo < TotalFrame-1)
            {
               
                pictureBox.Image = videoList[FrameNo].ToBitmap();
                FrameNo += 1;
                await Task.Delay(1000 / Convert.ToInt16(Fps));

            }
        }

        public void playVideo()
        {
            if (capture == null)
            {
                return;
            }
            
            ReadAllFrames();
        }
    }
}
