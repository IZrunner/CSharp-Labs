using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    abstract class SomeAbstractClass
    {
        protected int xCoord = 123;
        protected int yCoord = 456;
        protected int zCoord = 789;

        public abstract void ShowQuotation();
        public abstract void ShowDirection();       
    }

    class DoRightAction : SomeAbstractClass
    {
        public override void ShowQuotation()
        {
            Console.WriteLine("'If you've done 6 impossible things this morning, why not round it off with breakfast at Milliways, " +
            "\nthe Restaurant at the End of the Universe?'" +
            "\nDouglas Adams, 'The Restaurant at the End of the Universe'");
        }

        public override void ShowDirection()
        {
            Console.WriteLine($"You go to x : {xCoord}, y : {yCoord}, z : {zCoord}");
        }
    }

     class DoChaoticAction : SomeAbstractClass
     {
        sealed public override void ShowQuotation()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"You go to x : {xCoord}, y : {yCoord}, z : {zCoord}");
        }

        sealed public override void ShowDirection()
        {
            //throw new NotImplementedException();
            Console.WriteLine("'I must not fear. Fear is the mind-killer. Fear is the little death, that brings total obliteration. " +
         "\nI will face my fear. I will permit it to pass over me and through me. " +
         "\nAnd when it has gone past I will turn the inner eye to see its path. Where the fear has gone there will be nothing. " +
         "\nOnly I will remain.'" +
         "\nFrank Herbert, Dune");
        }
     }
}

