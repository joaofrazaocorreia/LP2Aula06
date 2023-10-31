using System;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        public bool Hibernating { get; set; }

        public void Roar()
        {
            if (!Hibernating)
            {
                Console.WriteLine("ROOOAAARRR!!!");
            }

            else
            {
                Console.WriteLine("The bear is hibernating.");
            }
        }

        public void LookAt(object objectToLookAt)
        {
            if(!Hibernating)
            {
                Console.WriteLine("The bear looks at the " + objectToLookAt.ToString());
            }

            else
            {
                Console.WriteLine("The bear is hibernating.");
            }
        }

        public void GoTowards(object objectToWalkTowards)
        {
            if(!Hibernating)
            {
                Console.WriteLine("The bear walks towards " + objectToWalkTowards.ToString());
            }

            else
            {
                Console.WriteLine("The bear is hibernating.");
            }
        }

        public bool TryEat(object objectToEat)
        {
            if(!Hibernating)
            {
                Console.WriteLine("The bear tries to eat " + objectToEat.ToString());
                return true;
            }

            else
            {
                Console.WriteLine("The bear is hibernating.");
                return false;
            }
        }

        public BrownBear(bool sleep)
        {
            Hibernating = sleep;
        }
    }
}