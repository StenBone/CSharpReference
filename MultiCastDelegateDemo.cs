using System;

namespace CSharpReference {


    /// <summary>
    /// A type that after it is initialized can point to functions.
    /// </summary>
    class MultiCastDelegateDemo {

        private delegate void IncrementCountDelegate();

        int count = 0;

        public MultiCastDelegateDemo() {
            IncrementCountDelegate incrementCount = upCountBy1;
            incrementCount += upCountBy2; // points to more than one method

            incrementCount();
            Console.WriteLine("MultiCastDelegatesDemo:count is " + count);
        }

        private void upCountBy1() {
            count++;
        }

        private void upCountBy2() {
            count += 2;
        }
    }
}
