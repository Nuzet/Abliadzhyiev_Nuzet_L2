using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
   abstract class Bank
   {
       abstract protected double timeToCredit { get; set ; }

       abstract  protected double creditSize { get; set; }

       abstract protected bool earlyRepayment { get; set; }

        abstract public void PrintCredit();

        abstract public void SearchCredit(double t, double s, bool e);
        



    }
}
