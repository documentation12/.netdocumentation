using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    public abstract class Bird
    {
        public abstract string MakeSound();

    }

    public class Sparrow : Bird
    {
        public override string MakeSound()
        {
            return "Chirp";
        }
    }
}
