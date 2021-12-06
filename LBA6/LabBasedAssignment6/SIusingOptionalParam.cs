using System;

namespace LabBasedAssignment6
{
    class SIusingOptionalParam
    {
        static void Main()
        {
            try
            {
                SIusingOptionalParam ob = new SIusingOptionalParam();
                Console.Write("ENTER PRINCIPAL = ");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.Write("ENTER RATE = ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.Write("ENTER TIME = ");
                int t = Convert.ToInt32(Console.ReadLine());
                double amt = 0;
                Console.WriteLine($"SIMPLE INTEREST IS {ob.calc(p, t, out amt,rate: r)} AND FINAL AMOUNT IS {amt} ");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        double calc(double pr, int time, out double amt, double rate = 10)
        {
            double SI = (pr * rate * time) / 100;
            amt = pr + SI;
            return SI;

        }
    }
}

