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
        ///Modulates amplitude of the carrier sin wave based on input sin wave.
        ///</Summary>
        ///<returns>
        ///Returns a modulated wave as a Int16.
        ///</returns>
        ///<param name="carrier">
        /// the sin wave to be modulated.
        ///</param>
        ///<param name="input">
        /// the modulating sin wave.
        ///</param>
        ///<param name="index">
        /// The ammount of modulation.
        ///</param>
        public static int sinAM(double carrier, double input, double index)
        {
            return Convert.ToInt16(Math.Sin(1 + index * input) * carrier);
        }

        ///<TODO> convert to use Wave class once made.</TODO>
        ///<Summary>
        ///Modulates amplitude of the carrier sin wave based on the input sin wave.
        ///</Summary>
        ///<returns>
        ///Returns a modulated wave as a Int16.
        ///</returns>
        ///<param name="carrierFrequency">
        /// the frequency of the sin wave to be modulated.
        ///</param>
        ///<param name="carrierRate">
        /// the rate of the sin wave to be modulated.
        ///</param>
        ///<param name="carrierAmplitude">
        /// the amplitude of the sin wave to be modulated.
        ///</param>
        ///<param name="inputFrequency">
        /// the frequency of the modulating sin wave.
        ///</param>
        ///<param name="inputRate">
        /// the rate of the modulating sin wave.
        ///</param>
        ///<param name="index">
        /// The ammount of modulation.
        ///</param>
        public static int sinFM(double index, float carrierFrequency, float carrierAmplitude, float carrierRate, float inputFrequency, float inputRate)
        {
            return Convert.ToInt16(carrierAmplitude * 
                Math.Sin(2 * Math.PI * (carrierFrequency + index *
                Math.Sin(2*Math.PI * inputFrequency * inputRate))));
        }
    }
}
