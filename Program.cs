using System;

namespace CSharpReference
{
    class Program {
        static void Main(string[] args) {

            //Program.Main(args); // demoing static methods

            if (args.Length > 0) {
                Console.WriteLine($"args[0]: {args[0]}"); // string interpolation
            }

            float radius = 2;
            float circumference = 2 * ConstantsDemo.PI * radius;
            

            // FORMAT SPECIFIER DEMO
            // format the output with formatting string
            Console.WriteLine($"Circumference {circumference:N3}");

            // MULTICAST DELEGATES DEMO
            Console.WriteLine(); 
            var mcdd = new MultiCastDelegateDemo();
            Console.WriteLine();

            // EVENTS DEMO
            Console.WriteLine(); 
            var ed = new EventsDemo();
            ed.WriteEventInfoToConsole += WriteToConsole;
            ed.WriteEventInfoToConsole += WriteToConsole;
            ed.WriteEventInfoToConsole -= WriteToConsole;
            ed.WriteEventInfoToConsole += WriteToConsole;
            // ed.WriteEventInfoToConsole = null; illegal operation
            ed.MethodThatFiresEvent();
            Console.WriteLine();

            // OBJECT REFERENCE DEMO
            Console.WriteLine();
            var obj1 = new Object();
            var obj2 = new Object();
            if (!Object.ReferenceEquals(obj1, obj2)) {
                Console.WriteLine("obj1 != obj2");
            }
            obj2 = obj1;
            if (Object.ReferenceEquals(obj1, obj2)) {
                Console.WriteLine("obj1 == obj2");
            }
            Console.WriteLine();

            // PASS BY VALUE DEMO
            Console.WriteLine();
            var ben = new ClassesDemo("Ben");
            Console.WriteLine($"ben's name is {ben.Name}");
            ChangeNameWithNewObject(ben, "Billy Joel");
            Console.WriteLine($"ben's nameafter ChangeNameWithNewObject is {ben.Name}");
            ChangeName(ben, "Bob");
            Console.WriteLine($"ben's changed name is {ben.Name}");
            Console.WriteLine();
            // tip: C# is always pass by value with parameters into methods. A reference passes the value of it's pointer.
            // Not an actual copy of the Object it's pointing to.

            // PASS BY REF DEMO
            Console.WriteLine();
            var john = new ClassesDemo("John");
            Console.WriteLine($"john's name is {john.Name}");
            ChangeNameByRef(ref john, "Joey");
            Console.WriteLine($"john's name after passing by ref is {john.Name}");
            ChangeNameByOut(out john, "Jed"); // works same as ref, except the compiler assumes john has not been initialized.
            Console.WriteLine($"john's name after passing by out is {john.Name}");
            Console.WriteLine();

            // PASS BY REF FOR VALUE TYPE DEMO
            Console.WriteLine();
            int largeNumber = int.MaxValue; //int is actually the alias for Int32, press F12 in VS to see
            Console.WriteLine($"Large number is {largeNumber}");
            ChangeIntTo1(largeNumber);
            Console.WriteLine($"Large number after funciton call is {largeNumber}");
            ChangeIntTo1Ref(ref largeNumber);
            Console.WriteLine($"Large number after ref funciton call is {largeNumber}");
            Console.WriteLine();

            // STRINGS ARE IMMUTABLE AND ACT AS VALUE TYPES
            Console.WriteLine();
            string name = "Gerold";
            name.ToUpper();
            Console.WriteLine($"name is {name}");
            Console.WriteLine();

            // POLYMORPHISM DEMO
            Console.WriteLine();
            var pd = new PolymorphismDemo();
            Console.WriteLine();

            // INTERFACES DEMO
            Console.WriteLine();
            var id = new InterfacesDemo();
            Console.WriteLine();



            // todo struct demo
            // todo using demo
            /*
             * using tells the compiler that you are using an object within a scope. 
             * the c# compiler will release and dispose of the object when you reach the last
             * curly brace or an exception is thrown.
             */
            // todo generics demo
            // todo parrallelism demo
            // todo nullable refernce types
            /*
             * Obj? obj = new Obj;
             * this says that the obj can hold null values
             * It says that you are prepared for nulls and have null checks in place
             */
            // todo LINQ

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

        static void ChangeName (ClassesDemo inCD, string inName) {
            inCD.Name = inName;
        }
        static void ChangeNameWithNewObject(ClassesDemo inCD, string inName) {
            inCD = new ClassesDemo(inName); // inCD is pointing at the value of a different object now
            inCD.Name = inName;
            // changed the value of the pointer inCD, not the value of the calling reference
        }

        static void ChangeNameByRef(ref ClassesDemo inCD, string inName) {
            inCD = new ClassesDemo(inName); 
        }

        static void ChangeNameByOut(out ClassesDemo inCD, string inName) {
            inCD = new ClassesDemo(inName); // out requires inCD to be initialized before exiting the method
        }

        static void ChangeIntTo1(int i) {
            i = 1;
        }
        static void ChangeIntTo1Ref(ref int i) {
            i = 1;
        }
    }
}
