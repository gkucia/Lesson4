using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Lab {

        private int rnd1;
        private int rnd2;

        public int random1 {
            get 
            {
                return this.rnd1;
            }
            set {
                if (1 <= value && value <= 20)
                {
                    this.rnd1 = value;
                }
                else 
                {
                    Console.WriteLine("Enter number from 1 to 20");
                }
            }

        }

   
        public int random2 {
            get {
                return this.rnd2;
            }
            set {
                this.rnd2 = value;
            }
        }

        public void print(int a, int b) {
            rnd1 = a;
            rnd2 = b;
            Console.WriteLine(rnd1);
            Console.WriteLine(rnd2);
            
        }

    
    }



    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            Lab l = new Lab();
            //l.random1 = Convert.ToInt32(Console.ReadLine());
            //l.random2 = rnd.Next(0, 30);

            int i = Convert.ToInt32(Console.ReadLine());
            int k = rnd.Next(0, 30);

            l.print(i, k);

            
        }
    }
}
