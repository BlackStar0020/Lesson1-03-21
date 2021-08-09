using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    class Program
    {
       static void Main(string[] args)
         {
             double a = 16.80;
             double b = 12.40;
             double result =Math.Round( Math.Sqrt(a*b), 2);
             Console.WriteLine($"result={result}");
             Console.ReadKey();
         }
         static void Main(string[] args)
          {
              double A = 1.40;
              double B = -5.50;
              double C = 0.60;
              double dlinaAC = A - C;
              double dlinaBC = Math.Abs(C - B);
              double summa = dlinaAC + dlinaBC;
              Console.WriteLine($"dlinaAC={dlinaAC}");
              Console.WriteLine($"dlinaBC={dlinaBC}");
              Console.WriteLine($"summa={summa}");
              Console.ReadKey();
          }
        static void Main(string[] args)
        {
            double X1 =-6.20, X2 = 2.10, Y1=5.20, Y2=9.80;
            double rastoyanie =Math.Round(( Math.Sqrt((Math.Pow((X2-X1), 2))+Math.Pow((Y2-Y1), 2))), 2);
            Console.WriteLine($"rastoyanie={rastoyanie}");
            Console.ReadKey();
       }
       static void Main(string[] args)
        {
            
          
            Console.Write("Vvedite chislo:");
            int ab = Convert.ToInt32(Console.ReadLine());
            int ba = ab / 10 + ab % 10 * 10;
            Console.WriteLine($"Chislo pri perestanovke sifr:{ba}" );
            Console.ReadKey();
        }
     static void Main(string[] args)
        {
            int N = 10985;
            int minut = 60;
            int polnikhminut = N / minut;
            Console.WriteLine($"polnikhminut={polnikhminut}");
            Console.ReadKey();
      
        }
      static void Main(string[] args)
        {
            int  odnanedelya = 7;
            Console.Write("Vvedite chislo:");
            int K = Convert.ToInt32(Console.ReadLine());
           //int K = int.Parse(Console.ReadLine());
            int dennedeli = K % odnanedelya;
            Console.WriteLine($"dennedeli:{dennedeli}");
            Console.ReadKey();
        }
       
    }
}
