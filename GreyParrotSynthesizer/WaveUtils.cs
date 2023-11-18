using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GreyParrotSynthesizer
{
    internal class WaveUtils
    {
        //enum to help simplify the wave choosing process through enum bound integers
        public enum WaveType
        {
            SINE = 1,
            SQUARE = 2,
            SAW = 3,
            TRIANGLE = 4,
            NOISE = 5
        }

        //function to return the wave function based on input of wave variables and chosen wavetype, returns Int16
        public static short[] WaveCalc(short[] wave, float frequency, WaveType waveType, int samepleRate = 44100, int seed = -1)
        {
            for (int i = 0; i < wave.Length; i++)
            {

                switch (waveType)
                {
                    default:
                        wave[i] = Convert.ToInt16(short.MaxValue * Math.Sin((2 * Math.PI * frequency / samepleRate) * i));
                        break;

                    case WaveType.SQUARE:
                        wave[i] = Convert.ToInt16(frequency * Math.Sign(Math.Sin((2 * Math.PI * frequency / samepleRate) * i)));
                        break;

                    case WaveType.SAW:
                        wave[i] = Convert.ToInt16(-frequency + (((frequency * 2) / samepleRate) * i));
                        break;

                    case WaveType.TRIANGLE:
                        int samplesPerWavelength = Convert.ToInt32(samepleRate / frequency);

                        short tempSample = (short)-frequency;

                        short amplitudeStep = Convert.ToInt16((frequency * 2) / samplesPerWavelength);

                        if (Math.Abs(tempSample) > frequency)
                        {
                            tempSample = (short)-frequency;
                        }

                        wave[i] = Convert.ToInt16(tempSample + amplitudeStep);

                        break;

                    case WaveType.NOISE:
                        Random rnd = new();
                        if (seed > 0) rnd = new(seed);
                        wave[i] = Convert.ToInt16(rnd.Next(-short.MaxValue, short.MaxValue));
                        break;
                }
            }

            return wave;
        }

    }
}
