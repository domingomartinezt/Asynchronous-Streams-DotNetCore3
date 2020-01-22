using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Press any key when ready.");
            Console.ReadLine();
            await foreach(var e in MessagesAsync()) {
                Console.WriteLine(e);
            }
        }

        private static IEnumerable<string> Messages() {
            yield return "Hello!";
            yield return "world!";
        }

        public async IAsyncEnumerable<string> MessagesAsync() {
            await Task.Delay(2000);
            yield return "Hello!";
            await Task.Delay(2000);
            yield return "World!";
        }
    }
}
