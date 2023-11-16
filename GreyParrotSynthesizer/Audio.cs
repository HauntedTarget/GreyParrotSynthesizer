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
        // Every second we want to generate SAMPLE_RATE samples (i.e. 44100 samples per second)
        // Every second, there will be 16 bits per sample (i.e. 16 bits per sample)
        private const int SAMPLE_RATE = 44100;
        private const short BITS_PER_SAMPLE = 16;

        public enum WaveType { SINE, SQUARE, SAWTOOTH, TRIANGLE, NOISE };

        public void PlaySound(float frequency, short amplitude, WaveType waveType) // WE MIGHT WANT TO ADD AN AMPLITUDE PARAMETER

        {

            // Only plays for like 1 second though.
            short[] wave = new short[SAMPLE_RATE];
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)]; // 2 * samplerate

            // https://learn.microsoft.com/en-us/archive/blogs/dawate/intro-to-audio-programming-part-4-algorithms-for-different-sound-waves-in-c
            // wave alogirthms made with help from the above link
            switch (waveType)
            {
                case WaveType.SINE:
                    wave = SineWave(frequency, amplitude);
                    break;
                case WaveType.SQUARE:
                    wave = SquareWave(frequency, amplitude);
                    break;
                case WaveType.SAWTOOTH:
                    wave = SawtoothWave(frequency, amplitude);
                    break;
                case WaveType.TRIANGLE:
                    wave = TriangleWave(frequency, amplitude);
                    break;
                case WaveType.NOISE:
                    wave = NoiseWave(frequency, amplitude);
                    break;
            }


            // http://soundfile.sapp.org/doc/WaveFormat/
            // wave file format made with help from the above link
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

        public static void SaveSound(float frequency, short amplitude, WaveType waveType, string filepath)
        {
            // TODO: I wanna do this later,, should be easy
            // Only plays for like 1 second though.
            short[] wave = new short[SAMPLE_RATE];
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)]; // 2 * samplerate

            // https://learn.microsoft.com/en-us/archive/blogs/dawate/intro-to-audio-programming-part-4-algorithms-for-different-sound-waves-in-c
            // wave alogirthms made with help from the above link
            switch (waveType)
            {
                case WaveType.SINE:
                    wave = SineWave(frequency, amplitude);
                    break;
                case WaveType.SQUARE:
                    wave = SquareWave(frequency, amplitude);
                    break;
                case WaveType.SAWTOOTH:
                    wave = SawtoothWave(frequency, amplitude);
                    break;
                case WaveType.TRIANGLE:
                    wave = TriangleWave(frequency, amplitude);
                    break;
                case WaveType.NOISE:
                    wave = NoiseWave(frequency, amplitude);
                    break;
            }


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

        #region WaveTypes
        private static short[] SineWave(float frequency, short amplitude)
        {
            short[] wave = new short[SAMPLE_RATE];
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                wave[i] = Convert.ToInt16(amplitude * Math.Sin((2 * Math.PI * frequency / SAMPLE_RATE) * i));
            }
            return wave;
        }

        private static short[] SquareWave(float frequency, short amplitude)
        {
            short[] wave = new short[SAMPLE_RATE];
            for (int i = 0; i < SAMPLE_RATE; i++)
            {
                wave[i] = Convert.ToInt16(amplitude * Math.Sign(Math.Sin((2 * Math.PI * frequency / SAMPLE_RATE) * i)));
            }
            return wave;
        }

        private static short[] SawtoothWave(float frequency, short amplitude)
        {
            
            int samplesPerWavelength = Convert.ToInt32(SAMPLE_RATE / frequency);

            short amplitudeStep = Convert.ToInt16((amplitude * 2) / samplesPerWavelength);

            short tempSample = (short)-amplitude;

            // Number of samples written so we know when to stop
            int totalSamplesWritten = 0;

            short[] wave = new short[SAMPLE_RATE];
            while (totalSamplesWritten < SAMPLE_RATE)
            {
                tempSample = (short)-amplitude;

                for (uint i = 0; i < samplesPerWavelength && totalSamplesWritten < SAMPLE_RATE; i++)
                {
                    // 2 is the number of channels (stereo)
                    for (int channel = 0; channel < 2; channel++)
                    {
                        tempSample += amplitudeStep;
                        wave[i] = tempSample;

                        totalSamplesWritten++;
                    
                    }
                }
            }
            return wave;
            
        }

        private static short[] TriangleWave(float frequency, short amplitude)
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
                    wave[i+ channel] = tempSample;
                }
            }
            return wave;
        }

        private static short[] NoiseWave(float frequency, short amplitude)
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
        #endregion WaveTypes


    }
}