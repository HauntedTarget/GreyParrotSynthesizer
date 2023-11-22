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
        public enum WaveType
        {
            SINE = 1,
            SQUARE = 2,
            SAW = 3,
            TRIANGLE = 4,
            NOISE = 5
        }

        public enum Notes
        {
            q = Keys.Q,
            two = Keys.D2,
            w = Keys.W,
            three = Keys.D3,
            e = Keys.E,
            r = Keys.R,
            five = Keys.D5,
            t = Keys.T,
            six = Keys.D6,
            // Origin of A (A4 on init)
            y = Keys.Y,
            seven = Keys.D7,
            u = Keys.U,
            i = Keys.I,
            nine = Keys.D9,
            o = Keys.O,
            zero = Keys.D0,
            p = Keys.P
        }

        //function to return the wave function based on input of wave variables and chosen wavetype, returns Int16
        public static short[] WaveCalc(short[] wave,float amplitude, float frequency, WaveType waveType, int samepleRate = 44100, int seed = -1)
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

                    case WaveType.SQUARE:
                        wave[i] = Convert.ToInt16(frequency * Math.Sign(Math.Sin((2 * Math.PI * frequency / samepleRate) * i)));
                        break;

                    case WaveType.SAW:
                        tempSample += amplitudeStep;
                        wave[i] = Convert.ToInt16(tempSample);
                        break;

                    case WaveType.TRIANGLE:
                        if (Math.Abs(tempSample) > amplitude)
                        {
                            tempSample = (short)-amplitudeStep;
                        }
                        tempSample += amplitudeStep;

                        wave[i] = Convert.ToInt16(tempSample);

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

    /*
     - Note Keys: q2w3er5t6y7ui9o0p
     - Octave Keys: -, +
     + 
     */
}
