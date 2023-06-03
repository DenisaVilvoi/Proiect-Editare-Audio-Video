using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    internal class EditFrame
    {
        Image<Bgr, byte> My_Image = null;
        public void setImage(Image<Bgr, byte> image)
        {
            this.My_Image = image;
        }
        public Image<Gray,Byte> grayscale(Image<Bgr,byte> image)
        {
            Image<Bgr, byte> inputImage = image; // Load your image here
            Image<Gray, byte>[] channels = inputImage.Split(); // Split the image into its individual color channels
            Image<Gray, byte> redChannel = channels[1];
            return redChannel;
        }
        public Image<Bgr, Byte> extractColor(Image<Bgr,Byte> image,Bgr color)
        {
            Image<Bgr, byte> inputImage = image;
            var img = inputImage.SubR(color);
            return img;
        }
        public Image<Bgr,byte> gamma(Image<Bgr, Byte> image,TextBox gamma)
        {
            Image<Bgr, byte> inputImage = image;
            inputImage._GammaCorrect(double.Parse(gamma.Text));
            return inputImage;
        }
        public Image<Bgr, byte> brightness(Image<Bgr, Byte> image, TextBox alpha,TextBox beta)
        {
            Image<Bgr, byte> inputImage = image;
            var img = inputImage.Mul(double.Parse(alpha.Text)) + double.Parse(beta.Text);
            return img;
        }
    }
}
