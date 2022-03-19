using System;

namespace funcjiaszescian
{
    class Program
    {
        static void Main(string[] args)
        {
            string dane;
            double a,b ,c,d, w, p, q, det, u, v, x1, x2, x3;
           dane= Console.ReadLine();
            string[] vs = dane.Split(" ");
            a = double.Parse(vs[0]);
            b= double.Parse(vs[1]);
            c = double.Parse(vs[2]);
            d = double.Parse(vs[3]);
            if (a == 0)
            {
               Console.WriteLine("Podano niepoprawne dane ");
                return;     }
            Console.WriteLine($"{a}x^3+{b}x^2+{c}x+{d}");

            w = (-b) / (3 * a);
            p = ((3 * a * w * w) + (2 * b * w) + c) / a;
            q = ((a * Math.Pow(w, 3)) + (b * Math.Pow(w, 2)) + c * w + d) / a;

            //pierewszy przypadek pierwiastek rzeczywisty i dwa zespolone 
            if




        }
    }
}
