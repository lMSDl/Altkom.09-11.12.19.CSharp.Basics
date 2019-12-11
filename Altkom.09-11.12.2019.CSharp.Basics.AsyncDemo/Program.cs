using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._2019.CSharp.Basics.AsyncDemo
{
    class Program
    {
        static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        static async Task MainAsync()
        {
            _ = MakeBreakfast();

            while (true)
            {
                Console.WriteLine(Console.ReadLine());
            }
        }


        static async Task MakeBreakfast()
        {
            List<Task> tasks = new List<Task>();

            var cofeeTask = PourCoffee();
            tasks.Add(cofeeTask);
            var eggsTask = BoilEggs();
            tasks.Add(eggsTask);
            var beconTask = FryBecon();
            tasks.Add(beconTask);
            var toastTask = MakeToasts();
            tasks.Add(toastTask);

            while (tasks.Any()) {
                var task = await Task.WhenAny(tasks);
                if(task == cofeeTask)
                    Console.WriteLine("Coffee ready");
                else if(task == eggsTask)
                    Console.WriteLine("Eggs ready");
                else if(task == beconTask)
                    Console.WriteLine("Becon ready");
                else if(task == toastTask)
                {
                    await AddButterToToasts();
                    Console.WriteLine("Toasts ready");
                }
                tasks.Remove(task);
            }
        }

        static Task PourCoffee()
        {
            return Task.Delay(1000);
        }

        static Task BoilEggs()
        {
            return Task.Delay(5000);
        }

        static Task MakeToasts()
        {
            return Task.Delay(3000);
        }

        static Task AddButterToToasts()
        {
            return Task.Delay(2000);
        }

        static Task FryBecon()
        {
            return Task.Delay(5000);
        }
    }
}
