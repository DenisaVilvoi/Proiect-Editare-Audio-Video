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
using Emgu.CV.Structure;
using System.Drawing;

namespace Proiect
{
    internal class Video:EditFrame
    {
        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;
        PictureBox pictureBox;
        List <Mat> videoList= new List<Mat>();
        List<Mat> backUpList = new List<Mat>();
        EditFrame editframe=new EditFrame();
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
            int frame = 2;
            while(frame < TotalFrame-1)
            {
                Mat mat = new Mat();
                this.capture.Read(mat); //capture e un fel de stiva in care punem mat-uri
                this.videoList.Add(mat);
                frame++;
            }
            backUpList.AddRange(videoList);
        }
        public void backUp()
        {
            videoList.Clear();
            int frame = 0;
            while (frame < TotalFrame - 3)
            {

                this.videoList.Add(backUpList[frame]);
                frame++;
            }
        }

        private async void ReadAllFrames()
        {

            Mat m = new Mat();
            while ( FrameNo < videoList.Count-1)
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
        public void grayScale()
        {
            backUp();
            for(int i=0; i < videoList.Count-1; i++)
            {
             videoList[i] = grayscale(videoList[i].ToBitmap().ToImage<Bgr, byte>()).Mat;
            }
        }
        public void extract(Bgr color)
        {
            backUp();
            for (int i = 0; i < videoList.Count - 1; i++)
            {
                videoList[i] = extractColor(videoList[i].ToBitmap().ToImage<Bgr, byte>(),color).Mat;
            }
        }
        public void carousel()
        {
            backUp();
            for (int i = 0; i < videoList.Count - 1; i++)
            {
                if (i > videoList.Count - 1) { break; }
                videoList[i] = grayscale(videoList[i].ToBitmap().ToImage<Bgr, byte>()).Mat;
                i++;
                if(i>videoList.Count - 1) { break; }
                videoList[i] = extractColor(videoList[i].ToBitmap().ToImage<Bgr, byte>(), new Bgr(0,0,255)).Mat;
                i++;
                if (i > videoList.Count - 1) { break; }
                videoList[i] = extractColor(videoList[i].ToBitmap().ToImage<Bgr, byte>(), new Bgr(0, 255, 0)).Mat;
                i++;
                if (i > videoList.Count - 1) { break; }
                videoList[i] = extractColor(videoList[i].ToBitmap().ToImage<Bgr, byte>(), new Bgr(255, 0, 0)).Mat;
            }
        }
        public void gammaCorection(TextBox textbox)
        {
            backUp();
            for (int i = 0; i < videoList.Count - 1; i++)
            {
                videoList[i] = gamma(videoList[i].ToBitmap().ToImage<Bgr, byte>(), textbox).Mat;
            }
        }
        public void brightnessVideo(TextBox alpha,TextBox beta)
        {
            backUp();
            for (int i = 0; i < videoList.Count - 1; i++)
            {
                videoList[i] = brightness(videoList[i].ToBitmap().ToImage<Bgr, byte>(), alpha,beta).Mat;
            }
        }
    }
}
