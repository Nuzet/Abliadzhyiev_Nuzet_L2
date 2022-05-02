using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class AgricoleBank: Bank
    {
        protected override double timeToCredit { get; set; } = 1;
        protected override double creditSize { get; set; } = 2500;
        protected override bool earlyRepayment { get; set; } = true;

        public override void PrintCredit()
        {
            Console.WriteLine($"AlgricoleBank:\nРозмiр кредiту: до {creditSize}$\t Час виплати: до {timeToCredit}р.\t Змога погасити однiєю платою:{earlyRepayment} ");
        }
        public override void SearchCredit(double t, double s, bool e)
        {
            if (timeToCredit >= t && creditSize >= s && e == earlyRepayment)
                PrintCredit();
            else
                Console.WriteLine("Кредiт вiд AgricoleBank Вам не пiдходить! ");
        }
    }
}
