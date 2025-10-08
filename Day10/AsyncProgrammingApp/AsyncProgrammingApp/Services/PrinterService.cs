using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgrammingApp.Services
{
    internal class PrinterService
    {

        public void Print() {

            while (true) {

                Debug.WriteLine($"Time is "+DateTime.Now.ToString("hh:mm:ss"));
            
            }
        }

        public void Print(int seconds) { 

            DateTime startTime = DateTime.Now;
            TimeSpan futureTime = TimeSpan.FromSeconds(seconds);
            while (DateTime.Now - startTime < futureTime) {

                Debug.WriteLine($"Time is " + DateTime.Now.ToString("hh:mm:ss"));

            }
        
        }

        public void PrintViaThread() {

            Thread worker = new Thread(() =>
            {
                Print(10);
            });
            worker.Start();
        
        }

        public void PrintViaTask() {

            Task.Run(() =>
            {
                Print(10);
            });
        }

        public Task PrintViaTaskWithAwaitable() {

            return Task.Run(() =>
            {
                Print(10);
            });
        }

        public Task<string> PrintViaTaskWithAwaitableResult()
        {

            return Task.Run(() =>
            {
                Print(10);
                return "Hello InsiteINTL work is done!!";
            });
        }



    }
}
