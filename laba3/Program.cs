using System;
using System.IO;
namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {

            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);


            int N, t;
            double x, y, z = 0;

            int i;
            double znam, chisl;

            N = Convert.ToInt32(Console.ReadLine()); 
            t = Convert.ToInt32(Console.ReadLine()); 
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            int l;
            if (t == 0)
            {
                for (i = 0; i <= N-1; i++)
                {
                    l = i + 1;
                    znam = l * (l + 2) * (l + 4);

                    if (i % 2 == 0) chisl = Math.Pow(x, i) - y;
                    else chisl = -(Math.Pow(y, i) + x);

                    z += chisl / znam;


                }
                Console.WriteLine(z);
            }

            else if (t == 1)
            {
                i = 0;
                while (i <= N-1)
                {
                    l = i + 1;
                    znam = l * (l + 2) * (l + 4);

                    if (i % 2 == 0) chisl = Math.Pow(x, i) - y;
                    else chisl = -(Math.Pow(y, i) + x);

                    z += chisl / znam;
                    i++;

                }
                Console.WriteLine(z);
            }
            else if (t == 2)
            {
                i = 0;
                do
                {
                    l = i + 1;
                    znam = l * (l + 2) * (l + 4);

                    if (i % 2 == 0) chisl = Math.Pow(x, i) - y;
                    else chisl = -(Math.Pow(y, i) + x);

                    z += chisl / znam;
                    i++;

                } while (i <= N-1);
                Console.WriteLine(z);
            }
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
