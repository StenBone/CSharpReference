using System;

namespace CSharpReference
{
    class Program {
        static void Main(string[] args) {

            float radius = 2;
            float circumference = 2 * ConstantsDemo.PI * radius;

            Console.WriteLine(); // MULTICAST DELEGATES DEMO
            var mcdd = new MultiCastDelegateDemo();
            Console.WriteLine();

            Console.WriteLine(); // EVENTS DEMO
            var ed = new EventsDemo();
            ed.WriteEventInfoToConsole += WriteToConsole;
            ed.WriteEventInfoToConsole += WriteToConsole;
            ed.WriteEventInfoToConsole -= WriteToConsole;
            ed.WriteEventInfoToConsole += WriteToConsole;
            // ed.WriteEventInfoToConsole = null; illegal operation
            ed.MethodThatFiresEvent();
            Console.WriteLine();

        }

        /// <summary>
        /// Demonstrating events
        /// This is the event handler
        /// Must be "static" inorder for it to be accessed by Main
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        static void WriteToConsole(Object sender, EventArgs args) {
            Console.WriteLine("Main:WriteToConsole");
        }

    }
}
