using NAudio.Wave.SampleProviders;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Audio
    {
        public void mixAudio()
        {
            using (var reader1 = new AudioFileReader("C:\\Users\\Denisa\\Desktop\\audio1.wav"))
            using (var reader2 = new AudioFileReader("C:\\Users\\Denisa\\Desktop\\audio2.wav"))
            {
                var mixer = new MixingSampleProvider(new[] { reader1, reader2 });
                WaveFileWriter.CreateWaveFile16("C:\\Users\\Denisa\\Desktop\\mixed.wav", mixer);
            }

        }
        public void combine()
        {
            var first = new AudioFileReader("C:\\Users\\Denisa\\Desktop\\mixed.wav");
            var second = new AudioFileReader("C:\\Users\\Denisa\\Desktop\\audio3.wav");
     

            var playlist = new ConcatenatingSampleProvider(new[] { first, second });
            WaveFileWriter.CreateWaveFile16("C:\\Users\\Denisa\\Desktop\\combine.wav", playlist);


        }
    }
}
