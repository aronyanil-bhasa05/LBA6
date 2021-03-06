using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBasedAssignment6
{
    class product
    {
        public int ProCode { get; set; }
        public string ProName { get; set; }
        public void ValidateProCode(int proCode, string proName)
        {
            this.ProCode = proCode;
            this.ProName = proName;

            if (this.ProCode >= 100 && this.ProCode <= 500)
            {
                Console.WriteLine($"Code={this.ProCode}\tName={this.ProName}");
            }
            else
            {
                throw new InvalidProCode();
            }
        }
    }

    class InvalidProCode : Exception
    {
        public InvalidProCode() : base("Invalid Product Code")
        {

        }
    }

    class TestProCode
    {
        static void Main()
        {
            try
            {
                Console.Write("ENTER PRODUCT CODE = ");
                int pc = Convert.ToInt32(Console.ReadLine());
                Console.Write("ENTER PRODUCT NAME = ");
                string pn = Console.ReadLine();
                product ob = new product();
                ob.ValidateProCode(pc, pn);
            }catch (InvalidProCode ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
