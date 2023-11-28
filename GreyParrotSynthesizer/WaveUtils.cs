using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GreyParrotSynthesizer
{
    internal class WaveUtils
    {
        //enum to help simplify the wave choosing process through enum bound integers
        

        //function to return the wave function based on input of wave variables and chosen wavetype, returns Int16
        public static short[] WaveCalc(short[] wave,float amplitude, float frequency, Audio.WaveType waveType, int samepleRate = 44100, int seed = -1)
        {
            short tempSample = (short)-amplitude;

            int samplesPerWavelength = Convert.ToInt32(samepleRate / frequency);

            short amplitudeStep = Convert.ToInt16((amplitude * 2) / samplesPerWavelength);

            for (int i = 0; i < wave.Length; i++)
            {

                switch (waveType)
                {
                    default:
                        wave[i] = Convert.ToInt16(short.MaxValue * Math.Sin((2 * Math.PI * frequency / samepleRate) * i));
                        break;

                    case Audio.WaveType.SQUARE:
                        wave[i] = Convert.ToInt16(frequency * Math.Sign(Math.Sin((2 * Math.PI * frequency / samepleRate) * i)));
                        break;

                    case Audio.WaveType.SAWTOOTH:
                        tempSample += amplitudeStep;
                        wave[i] = Convert.ToInt16(tempSample);
                        break;

                    case Audio.WaveType.TRIANGLE:
                        if (Math.Abs(tempSample) > amplitude)
                        {
                            tempSample = (short)-amplitudeStep;
                        }
                        tempSample += amplitudeStep;

                        wave[i] = Convert.ToInt16(tempSample);

                        break;

                    case Audio.WaveType.NOISE:
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
