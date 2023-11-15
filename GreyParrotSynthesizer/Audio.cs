using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Drawing.Text;

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

        public static Enum waveType { SINE, SQUARE, SAWTOOTH, TRIANGLE, NOISE };

        public static void PlaySineSound(float frequency, short amplitude) // WE MIGHT WANT TO ADD AN AMPLITUDE PARAMETER
        {

            // Only plays for like 1 second though.
            short[] wave = new short[SAMPLE_RATE];
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)]; // 2 * samplerate

            switch (waveType)
            {
                case waveType.SINE:
                    wave = SineWave(frequency, amplitude);
                    break;
                case waveType.SQUARE:
                    wave = SquareWave(frequency, amplitude);
                    break;
                case waveType.SAWTOOTH:
                    wave = SawtoothWave(frequency, amplitude);
                    break;
                case waveType.TRIANGLE:
                    wave = TriangleWave(frequency, amplitude);
                    break;
                case waveType.NOISE:
                    wave = NoiseWave(frequency, amplitude);
                    break;
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
        private short[] SineWave(float frequency, short amplitude)
        {
            short[] wave = new short[SAMPLE_RATE];
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                wave[i] = Convert.ToInt16(amplitude * Math.Sin((2 * Math.PI * frequency / SAMPLE_RATE) * i));
            }
            return wave;
        }

        private short[] SquareWave(float frequency, short amplitude)
        {
            short[] wave = new short[SAMPLE_RATE];
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                wave[i] = Convert.ToInt16(amplitude * Math.Sign(Math.Sin((2 * Math.PI * frequency / SAMPLE_RATE) * i)));
            }
            return wave;
        }

        private short[] SawtoothWave(float frequency, short amplitude)
        {
            // TODO: Implement this
            short[] wave = new short[SAMPLE_RATE];
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                wave[i] = Convert.ToInt16(amplitude * Math.Sin((2 * Math.PI * frequency / SAMPLE_RATE) * i));
            }
            return wave;
        }

        private short[] TriangleWave(float frequency, short amplitude)
        {
            // TODO: Implement this
            short[] wave = new short[SAMPLE_RATE];
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                wave[i] = Convert.ToInt16(amplitude * Math.Sin((2 * Math.PI * frequency / SAMPLE_RATE) * i));
            }
            return wave;
        }

        private short[] NoiseWave(float frequency, short amplitude)
        {
            Random random = new Random();
            short randomValue = 0;

            short[] wave = new short[SAMPLE_RATE];
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                randomValue = Convert.ToInt16(random.Next(-amplitude, amplitude));
                wave[i] = randomValue;
            }
            return wave;
        }


    }
}