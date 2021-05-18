using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReference {
    class InterfacesDemo {
        public InterfacesDemo() {
            var baseWidget = new BaseWidget("Tim's base widget thingy");
            baseWidget.DoSomething("Howdy");
            baseWidget.WriteYourName();
        }
    }

    public class BaseWidget : Base, IWidget {
        public string Name { get; }

        public BaseWidget(string inName) {
            this.Name = inName;
        }

        public void WriteThisNum(int num) {
            Console.WriteLine($"My num is {num}");
        }

        public void WriteYourName() {
            Console.WriteLine($"My name is {Name}");
        }
        public override void DoSomething(string inStr) {
            Console.WriteLine($"Dave says {inStr}");
        }
    }

    public interface IWidget { // By convention interfaces start with I
        public void WriteYourName();
        void WriteThisNum(int num); // implicitly public
        string Name { get; }
    }
}
