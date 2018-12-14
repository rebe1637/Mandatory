using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Conv

    {
        public static void ToLB(double Weight, string type)
        {

            double Weightgram, kgtopounds;


            if (SomeWeightInOunces())
            /// Covert to Oz
            {
                Weightgram = Weight * 1000;

                kgtopounds = 2.204627 * Weight;


                Weightgram = Weightgram * 0.035274;
                Console.WriteLine("\n");
                Console.WriteLine(kgtopounds);

            }

        }

        public static void ToGram(double Weight, string type)
        {
            // Convert to grams
            double Weightgram, poundsToGram;

            if (SomeWeightInGrams())

            {
                Weightgram = Weight / 1000;

                poundsToGram = Weight / 2.204627;


                Weightgram = Weightgram * 0.035274;
                Console.WriteLine("\n");
                Console.WriteLine(poundsToGram);

            }



        }

        private static bool SomeWeightInGrams()
        {
            throw new NotImplementedException();
        }

        private static bool SomeWeightInOunces()
        {
            throw new NotImplementedException();
        }


    }
}


