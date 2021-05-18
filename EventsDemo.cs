using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReference {

    public delegate void WriteEventInfoToConsoleDelegate(Object sender, EventArgs args);

    /// <summary>
    /// 
    /// </summary>
    class EventsDemo {

        // the "event" keyword adds some restrictions to the delegate to make it safer to use
        public event WriteEventInfoToConsoleDelegate WriteEventInfoToConsole;

        public void MethodThatFiresEvent() {

            // do some work, for instance adding an item to a database

            // is someone listening to this event?
            if (WriteEventInfoToConsole != null) {
                // if someone is listening, they will be notified
                WriteEventInfoToConsole(this, new EventArgs()); // raises event
            }
        }
    }
}
