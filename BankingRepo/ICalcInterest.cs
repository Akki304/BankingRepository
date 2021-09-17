using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingRepo
{
    public interface ICalcInterest
    {
         int Calculate(int principal, int roi, int years);
    }
}
