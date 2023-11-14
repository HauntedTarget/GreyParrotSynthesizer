using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;



namespace GreyParrotSynthesizer
{
    internal class Audio
    {

        // https://learn.microsoft.com/en-us/archive/blogs/dawate/intro-to-audio-programming-part-4-algorithms-for-different-sound-waves-in-c
        // http://soundfile.sapp.org/doc/WaveFormat/
        // Every second we want to generate SAMPLE_RATE samples (i.e. 44100 samples per second)
        // Every second, there will be 16 bits per sample (i.e. 16 bits per sample)
        private const int SAMPLE_RATE = 44100;
        private const short BITS_PER_SAMPLE = 16;

        public static void PlaySineSound(float frequency = 200f) // WE MIGHT WANT TO ADD AN AMPLITUDE PARAMETER
        {

            // Only plays for like 1 second though.
            short[] wave = new short[SAMPLE_RATE];
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)]; // 2 * samplerate
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                // This is a sine wave
                // Could have a switch statement here for multiple wave types
                wave[i] = Convert.ToInt16(short.MaxValue * Math.Sin((2 * Math.PI * frequency / SAMPLE_RATE) * i));
            }
            Buffer.BlockCopy(wave, 0, binaryWave, 0, wave.Length * sizeof(short));
            // Can also use FileSteam to write to a file so we can save it for later
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter binWriter = new BinaryWriter(memoryStream))
            {
                short blockAlign = BITS_PER_SAMPLE / 8;
                int subChunkTwoSize = SAMPLE_RATE * blockAlign;
                // HEAD CHUNK
                binWriter.Write(new char[] { 'R', 'I', 'F', 'F' });
                binWriter.Write(36 + subChunkTwoSize);
                binWriter.Write(new char[] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
                binWriter.Write(16);
                binWriter.Write((short)1);
                binWriter.Write((short)1);
                binWriter.Write(SAMPLE_RATE);
                binWriter.Write(SAMPLE_RATE * blockAlign);
                binWriter.Write(blockAlign);
                binWriter.Write(BITS_PER_SAMPLE);
                // DATA CHUNK
                binWriter.Write(new char[] { 'd', 'a', 't', 'a' });
                binWriter.Write(subChunkTwoSize);
                binWriter.Write(binaryWave);
                // Point the stream pointer to the beginning of the stream
                memoryStream.Position = 0;
                new SoundPlayer(memoryStream).Play();
            }

        }

        public static void PlayNoise(int seed = -1)
        {
            Random rnd = new Random();

            if (seed > 0)
            {
                rnd = new(seed);
            }

            short randomValue = 0;

            // Only plays for like 1 second though.
            short[] wave = new short[SAMPLE_RATE];
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)]; // 2 * samplerate
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                //Noise wave, short.maxvalue is amplitude so negetive is the lower of it
                randomValue = Convert.ToInt16(rnd.Next(-short.MaxValue, short.MaxValue));
                wave[i] = randomValue;
            }
            Buffer.BlockCopy(wave, 0, binaryWave, 0, wave.Length * sizeof(short));
            // Can also use FileSteam to write to a file so we can save it for later
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter binWriter = new BinaryWriter(memoryStream))
            {
                short blockAlign = BITS_PER_SAMPLE / 8;
                int subChunkTwoSize = SAMPLE_RATE * blockAlign;
                // HEAD CHUNK
                binWriter.Write(new char[] { 'R', 'I', 'F', 'F' });
                binWriter.Write(36 + subChunkTwoSize);
                binWriter.Write(new char[] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
                binWriter.Write(16);
                binWriter.Write((short)1);
                binWriter.Write((short)1);
                binWriter.Write(SAMPLE_RATE);
                binWriter.Write(SAMPLE_RATE * blockAlign);
                binWriter.Write(blockAlign);
                binWriter.Write(BITS_PER_SAMPLE);
                // DATA CHUNK
                binWriter.Write(new char[] { 'd', 'a', 't', 'a' });
                binWriter.Write(subChunkTwoSize);
                binWriter.Write(binaryWave);
                // Point the stream pointer to the beginning of the stream
                memoryStream.Position = 0;
                new SoundPlayer(memoryStream).Play();
            }

        }
    }
}