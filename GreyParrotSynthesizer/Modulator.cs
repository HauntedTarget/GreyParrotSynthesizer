using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyParrotSynthesizer
{
    internal class Modulator
    {
        ///<TODO> convert to use Wave class once made.</TODO>
        ///<Summary>
        ///Modulates amplitude of the carrier wave based on input wave.
        ///</Summary>
        ///<returns>
        ///Returns a modulated wave as a Int16.
        ///</returns>
        ///<param name="carrier">
        /// the wave to be modulated.
        ///</param>
        ///<param name="input">
        /// the modulating wave.
        ///</param>
        ///<param name="index">
        /// The ammount of modulation.
        ///</param>
        public static int AM(double carrier, double input, double index)
        {
            return Convert.ToInt16(Math.Sin(1 + index * input) * carrier);
        }

        ///<TODO> convert to use Wave class once made.</TODO>
        ///<Summary>
        ///Modulates amplitude of the carrier wave based on input wave.
        ///</Summary>
        ///<returns>
        ///Returns a modulated wave as a Int16.
        ///</returns>
        ///<param name="carrierFrequency">
        /// the frequency of wave to be modulated.
        ///</param>
        ///<param name="carrierRate">
        /// the rate of wave to be modulated.
        ///</param>
        ///<param name="carrierAmplitude">
        /// the amplitude of wave to be modulated.
        ///</param>
        ///<param name="inputFrequency">
        /// the frequency of modulating wave.
        ///</param>
        ///<param name="inputRate">
        /// the rate of modulating wave.
        ///</param>
        ///<param name="index">
        /// The ammount of modulation.
        ///</param>
        public static int FM(double index, float carrierFrequency, float carrierAmplitude, float carrierRate, float inputFrequency, float inputRate)
        {
            return Convert.ToInt16(carrierAmplitude * 
                Math.Sin(2 * Math.PI * carrierFrequency * carrierRate + index *
                Math.Sin(2*Math.PI * inputFrequency * inputRate)));
        }
    }
}
