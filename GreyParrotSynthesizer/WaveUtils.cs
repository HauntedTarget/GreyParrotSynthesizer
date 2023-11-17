﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
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
            NOISE = 4
        }

        //function to return the wave function based on input of wave variables and chosen wavetype, returns Int16
        public static Int16 WaveCalc(float frequency, int waveLocation, WaveType waveType, int samepleRate = 44100, int seed = -1)
        {
            switch (waveType)
            {
                default:
                    return Convert.ToInt16(short.MaxValue * Math.Sin((2 * Math.PI * frequency / samepleRate) * waveLocation));

                case WaveType.SQUARE:
                    return Convert.ToInt16(frequency * Math.Sign(Math.Sin((2 * Math.PI * frequency / samepleRate) * waveLocation)));

                case WaveType.SAW:
                    return Convert.ToInt16(-frequency + ( ((frequency * 2) / samepleRate) * waveLocation));

                case WaveType.NOISE:
                    Random rnd = new();
                    if (seed > 0) rnd = new(seed);
                    return Convert.ToInt16(rnd.Next(-short.MaxValue, short.MaxValue));
            }
        }

    }
}
