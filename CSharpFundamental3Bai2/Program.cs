using System;
using System.Threading.Tasks;

namespace CSharpFundamental3Bai2
{
    class Program
    {
        public static async void PrimeNumber(int start, int end)
        {
            await Task.Run(() => 
            {
                int demNT;
                if(start == 0) Console.WriteLine("Nhap so bat dau lon hon 0!");
                else
                {
                    for(int i = start; i<=end; i++)
                    {
                        demNT = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if(i%j==0)
                                demNT++;
                        }
                        if(demNT==2)
                        {
                            Console.Write(i+" ");
                            Task.Delay(100).Wait();
                        }
                    }
                }
            });
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("0 -> 100:");
            //So Khong chia duoc cho 0
            PrimeNumber(0,100);
            //Console.WriteLine("\n1 -> 100:");
            PrimeNumber(1,100);
            //Console.WriteLine("\n101 -> 200:");
            PrimeNumber(101,200);
            Console.ReadKey();
        }
    }
}
