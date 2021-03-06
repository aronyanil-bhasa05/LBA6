using System;

namespace LabBasedAssignment6
{
    class SIusingOutParameter
    {
        static void Main()
        {
            try
            {
                SIusingOutParameter ob = new SIusingOutParameter();
                Console.Write("ENTER PRINCIPAL = ");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.Write("ENTER RATE = ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.Write("ENTER TIME = ");
                int t = Convert.ToInt32(Console.ReadLine());
                double amt = 0;
                Console.WriteLine($"SIMPLE INTEREST IS {ob.calc(p, r, t, out amt)} AND FINAL AMOUNT IS {amt} ");
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

        double calc(double pr, double rate, int time, out double amt)
        {
            double SI = (pr * rate * time) / 100;
            amt = pr + SI;
            return SI;

        }
    }
}
