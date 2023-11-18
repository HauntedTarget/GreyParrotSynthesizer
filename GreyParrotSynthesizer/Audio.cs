using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Drawing.Text;
using static GreyParrotSynthesizer.WaveUtils;
using System.ComponentModel.Design;
using Accord.Statistics.Kernels;

namespace GreyParrotSynthesizer
{
    internal class Audio
    {
        // Every second we want to generate SAMPLE_RATE samples (i.e. 44100 samples per second)
        // Every second, there will be 16 bits per sample (i.e. 16 bits per sample)
        private const int SAMPLE_RATE = 44100;
        private const short BITS_PER_SAMPLE = 16;

        public static void PlaySound(float frequency, short amplitude, WaveType waveType, int seed = -1) // WE MIGHT WANT TO ADD AN AMPLITUDE PARAMETER

        {
            // Only plays for like 1 second though.
            short[] wave = new short[SAMPLE_RATE];
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)]; // 2 * samplerate

            // https://learn.microsoft.com/en-us/archive/blogs/dawate/intro-to-audio-programming-part-4-algorithms-for-different-sound-waves-in-c
            // wave alogirthms made with help from the above link
            wave = WaveUtils.WaveCalc(wave, amplitude, frequency, waveType, SAMPLE_RATE, seed);



            // http://soundfile.sapp.org/doc/WaveFormat/
            // wave file format made with help from the above link
            Buffer.BlockCopy(wave, 0, binaryWave, 0, wave.Length* sizeof(short));
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

        public static void SaveSound(float frequency, short amplitude, WaveType waveType, string filepath, int seed = -1)
        {
            // TODO: I wanna do this later,, should be easy
            // Only plays for like 1 second though.
            short[] wave = new short[SAMPLE_RATE];
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)]; // 2 * samplerate

            // https://learn.microsoft.com/en-us/archive/blogs/dawate/intro-to-audio-programming-part-4-algorithms-for-different-sound-waves-in-c
            // wave alogirthms made with help from the above link
            wave = WaveUtils.WaveCalc(wave, amplitude, frequency, waveType, SAMPLE_RATE, seed);


            // http://soundfile.sapp.org/doc/WaveFormat/
            // wave file format made with help from the above link
            Buffer.BlockCopy(wave, 0, binaryWave, 0, wave.Length * sizeof(short));
            // Can also use FileSteam to write to a file so we can save it for later
            using (FileStream fileStream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            using (BinaryWriter binWriter = new BinaryWriter(fileStream))
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

                // Close the file
                binWriter.Close();
                fileStream.Close();
                
                
            }
        }

        /*private static short[] TriangleWave(float frequency, short amplitude)
        {
            int samplesPerWavelength = Convert.ToInt32(SAMPLE_RATE / frequency);

            short amplitudeStep = Convert.ToInt16((amplitude * 2) / samplesPerWavelength);

            short tempSample = (short)-amplitude;

            short[] wave = new short[SAMPLE_RATE];
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                for (int channel = 0 ; channel < 2 ; channel++)
                {
                    if (Math.Abs(tempSample) > amplitude)
                    {
                        tempSample = (short)-amplitude;
                    }
                    tempSample += amplitudeStep;
                    wave[i] = tempSample;
                }
            }
            return wave;
        }*/


    }
}