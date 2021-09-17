using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingRepo
{
    public class CalcInterest : ICalcInterest
    {
        public int Calculate(int principal, int roi, int years)
        {
            int si = (principal * roi * years) / 100;
            return si;
        }
    }
}
