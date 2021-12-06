using System;


namespace LabBasedAssignment6
{
    class factorial
    {
        static void Main()
        {
            factorial facto= new factorial();
            Console.Write("ENTER A NUMBER = ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"FACTORIAL OF {n} IS {facto.fact(n)} ");
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
