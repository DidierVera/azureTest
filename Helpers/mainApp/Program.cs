using System;

namespace mainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("format numer app: ");

            var value = double.Parse(Console.ReadLine());

            MoneyHelperCL.MoneyFormatHelper helper = new MoneyHelperCL.MoneyFormatHelper();
            var valueFormater = helper.FormatNumber(value);
            Console.WriteLine(string.Format("previus value formetter is: {0}", valueFormater));
            
        }
    }
}
