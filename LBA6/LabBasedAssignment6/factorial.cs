using System;


namespace LabBasedAssignment6
{
    class factorial
    {
        static void Main()
        {
            try
            {
                factorial facto = new factorial();
                Console.Write("ENTER A NUMBER = ");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"FACTORIAL OF {n} IS {facto.fact(n)} ");
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

        double fact (double num)
        {
            if (num == 0)
                return 1;
            else
                return (num*fact(num - 1));
        }

        

    }
}
