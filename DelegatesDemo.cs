using System ;

namespace CSharpReference {

    // Define the signature of the function
    // Can point to any method that returns a string and points to a string
    public delegate string WriteLogDelegate(string logMessage);
    
    /// <summary>
    /// A type that after it is initialized can point to functions.
    /// </summary>
    class DelegatesDemo {

        DelegatesDemo() {
            WriteLogDelegate log;
            log = WriteTestString; // point delegate to function

            var result = log("this is a test");
        }

        string WriteTestString(string inMessage) {
            var printMessage = "CSharpReference:WriteTestString\n" + inMessage;
            Console.WriteLine(printMessage);
            return printMessage;
        }
    }
}
