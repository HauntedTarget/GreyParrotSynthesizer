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

        /*public enum Notes
        {
            Q = -9,
            two = -8,
            W = -7,
            three = -6,
            E = -5,
            R = -4,
            five = -3,
            T = -2,
            six = -1,
            // Origin of A (A4 on init)
            Y = 0,
            seven = 1,
            U = 2,
            I = 3,
            nine = 4,
            O = 5,
            zero = 6,
            P = 7
        }*/

        public static float KeyToNote(KeyPressEventArgs keyPressed, short octave)
        {
            // frequency of C note: 523.25
            // note frequency algorithm = 440 * (1.059463..)^n
            // n = steps away from A4
            //10 between octave
            float frequency = 0;
            int n = 0;
            n += (octave * 10);
            n -= 40;

            switch (keyPressed.KeyChar)
            {
                default:
                    return 0;
                case 'q':
                    n -= 9; break;
                case '2':
                    n -= 8; break;
                case 'w':
                    n -= 7; break;
                case '3':
                    n -= 6; break;
                case 'e':
                    n -= 5; break;
                case 'r':
                    n -= 4; break;
                case '5':
                    n -= 3; break;
                case 't':
                    n -= 2; break;
                case '6':
                    n -= 1; break;
                case 'y':
                    break;
                case '7':
                    n += 1; break;
                case 'u':
                    n += 2; break;
                case 'i':
                    n += 3; break;
                case '9':
                    n += 4; break;
                case 'o':
                    n += 5; break;
                case '0':
                    n += 6; break;
                case 'p':
                    n += 7; break;
            }
            float scalar = MathF.Pow(1.059463f, n);

            frequency = 440 * scalar;
            return frequency;
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
