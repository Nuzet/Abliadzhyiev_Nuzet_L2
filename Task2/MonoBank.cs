using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class MonoBank : Bank
    {
        protected override double timeToCredit { get; set; } = 0.5;
        protected override double creditSize { get; set; } = 1000;
        protected override bool earlyRepayment { get; set; } = false;

        public override void PrintCredit()
        {
            Console.WriteLine($"MonoBank:\nРозмiр кредiту: до {creditSize}$\t Час виплати: до {timeToCredit}р.\t Змога погасити однiєю платою:{earlyRepayment} ");
        }

        public override void SearchCredit(double t, double s, bool e)
        {
            if (timeToCredit >= t && creditSize >= s && e == earlyRepayment)
                PrintCredit();
            else
                Console.WriteLine("Кредiт вiд MonoBank Вам не пiдходить! ");
        }
    }
}
