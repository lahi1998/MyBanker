using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal abstract class Cards
    {

        protected string? Name;
        protected string? CardNumber;
        protected string? AcountNumber;
        protected int Age;

        internal abstract string GenerateCardNumber();
        internal abstract string GenerateAcountNumber();

        internal abstract string Generatecard();
    }
}
