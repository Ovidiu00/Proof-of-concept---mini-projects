using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MakingCoffeAsync
{
    class Program
    {
        private static Object lockObj = new Object();
        private static void ShowThreadInformation(String taskName)
        {
            String msg = null;
            Thread thread = Thread.CurrentThread;
            lock (lockObj)
            {
                msg = String.Format("{0} thread information\n", taskName) +
                      String.Format("   Thread Pool: {0}\n", thread.IsThreadPoolThread) +
                      String.Format("   Thread ID: {0}\n", thread.ManagedThreadId);
            }
            Console.WriteLine(msg);
        }

        static async Task Main(string[] args)
        {
            ShowThreadInformation("MAIN METHOD");

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            ShowThreadInformation("MakeToastWithButterAndJamAsync METHOD - before await");

            var toast = await ToastBreadAsync(number);
            ShowThreadInformation("MakeToastWithButterAndJamAsync METHOD - after await");

            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            ShowThreadInformation("ToastBread METHOD");



            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(90000);

            ShowThreadInformation("ToastBread METHOD - after await");

            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            ShowThreadInformation("FRY BACON METHOD- before first await");


            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(90000);

            ShowThreadInformation("FRY BACON METHOD- after first await");

            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(30000);

            ShowThreadInformation("FRY BACON METHOD- after second await");

            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            ShowThreadInformation("FRY EGGS METHOD - before first await");


            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(90000);

            ShowThreadInformation("FRY EGGS METHOD - after first await");

            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(30000);

            ShowThreadInformation("FRY EGGS METHOD - after second await");

            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            ShowThreadInformation("Pour coffe METHOD");


            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
