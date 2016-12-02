using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting...");
            //DoSomethingAsync();
            Deadlock();
            
            Console.WriteLine("stoped...");
            Console.ReadLine();
        }

        public static async Task DoSomethingAsync()
        {
            int val = 13;

            await Task.Delay(TimeSpan.FromSeconds(5)).ConfigureAwait(false);
            val *= 2;

            await Task.Delay(TimeSpan.FromSeconds(5)).ConfigureAwait(false);

            Console.WriteLine(val);
        }

        public static async Task WaitAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            
        }

        public static async void Deadlock()
        {
            Task task = WaitAsync();

            task.Wait();
        }

      
    }
}
