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
        static UserWaveView userWaveView = new UserWaveView();
        // Every second we want to generate SAMPLE_RATE samples (i.e. 44100 samples per second)
        // Every second, there will be 16 bits per sample (i.e. 16 bits per sample)
        private const int SAMPLE_RATE = 44100;
        private const short BITS_PER_SAMPLE = 16;

        public static void PlaySound(float frequency, short amplitude, WaveType waveType, float seconds, int seed = -1)
        {
            // Only plays for like 1 second though.
            int waveLength = (int)(SAMPLE_RATE * seconds);
            short[] wave = new short[waveLength];
            byte[] binaryWave = new byte[waveLength * sizeof(short)]; // 2 * size of wave

            // https://learn.microsoft.com/en-us/archive/blogs/dawate/intro-to-audio-programming-part-4-algorithms-for-different-sound-waves-in-c
            // wave alogirthms made with help from the above link
            wave = WaveUtils.WaveCalc(wave, amplitude, frequency, waveType, SAMPLE_RATE, seed);
            // Send wave to userWaveView

            SendWaveToWaveView(wave);


            // https://docs.fileformat.com/audio/wav/
            // wave file format made with help from the above link
            Buffer.BlockCopy(wave, 0, binaryWave, 0, wave.Length * sizeof(short));
            // Can also use FileSteam to write to a file so we can save it for later
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter binWriter = new BinaryWriter(memoryStream))
            {
                short blockAlign = BITS_PER_SAMPLE / 8;
                int subChunkTwoSize = (int)(SAMPLE_RATE * blockAlign * seconds);
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

        public static void PlaySoundFromFile(string filename)
        {
            GetWaveFromWav(filename);
            try
            {
                new SoundPlayer(filename).Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void PlayAllSoundsFromFiles(string filename)
        {
            int numeberOfFiles = 10;
            string path;
            for (int i = 1; i <= numeberOfFiles; i++)
            {
                path = filename + i;
                GetWaveFromWav(path);
                PlaySoundFromFile(path);
                // need to figure out how to get length of sound in milliseconds
                Wait(500); 
            }

        }


        private static void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private static void SendWaveToWaveView(short[] wave)
        {
            //MessageBox.Show("Wave length: " + wave.Length);
            int newIndex = 0;
            int cutby = 735;
            short[] newWave = new short[(wave.Length / cutby) + 1];
            //MessageBox.Show("New wave length: " + newWave.Length + " Wave Length: " + wave.Length);
            for (int i = 0; i < wave.Length; i++)
            {
                if (i % cutby == 0)
                {
                    newWave[newIndex] = wave[i];
                    newIndex++;
                }
            }
            UserWaveView.wave = newWave;
        }
        
        private static void GetWaveFromWav(string filepath)
        {
            if (File.Exists(filepath))
            {
                using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite))
                using (BinaryReader binReader = new BinaryReader(fileStream))
                {
                    binReader.ReadBytes(4); // RIFF
                    int arraysize = binReader.ReadInt32(); // ChunkSize
                    binReader.ReadBytes(8); // WAVEfmt
                    binReader.ReadInt32(); // Subchunk1Size
                    binReader.ReadBytes(2); // AudioFormat
                    binReader.ReadBytes(2); // NumChannels
                    binReader.ReadInt32(); // SampleRate
                    binReader.ReadInt32(); // ByteRate
                    binReader.ReadBytes(2); // BlockAlign
                    binReader.ReadBytes(2); // BitsPerSample
                    binReader.ReadBytes(4); // data
                    binReader.ReadInt32(); // Subchunk2Size
                    byte[] bytearray = binReader.ReadBytes(arraysize - 32); // Data
                    short[] wave = new short[bytearray.Length / 2];
                    Buffer.BlockCopy(bytearray, 0, wave, 0, bytearray.Length);
                    if (wave.Length > 0) {
                        SendWaveToWaveView(wave);
                    }
                    
                }
            }
        }

        public static void SaveSound(float frequency, short amplitude, WaveType waveType, float seconds, string filepath, int seed = -1)
        {
            filepath = filepath + ".wav";
            // Only plays for like 1 second though.
            int waveLength = (int)(SAMPLE_RATE * seconds);
            short[] wave = new short[waveLength];
            byte[] binaryWave = new byte[waveLength * sizeof(short)]; // 2 * size of wave

            // https://learn.microsoft.com/en-us/archive/blogs/dawate/intro-to-audio-programming-part-4-algorithms-for-different-sound-waves-in-c
            // wave alogirthms made with help from the above link
            wave = WaveUtils.WaveCalc(wave, amplitude, frequency, waveType, SAMPLE_RATE, seed);
            //SendWaveToWaveView(wave);


            // https://docs.fileformat.com/audio/wav/
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

                //new SoundPlayer(filepath).Play();
                
                
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