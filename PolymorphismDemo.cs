using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReference {
    class PolymorphismDemo {
        public PolymorphismDemo() {
            var steve = new ParentSteve();
            var dave = new ParentDave();

            Base[] arr = { steve, dave };
            arr[0].DoSomething("Sup");
            arr[1].DoSomething("Yo");
        }
    }


    public abstract class Base {
        public abstract void DoSomething(string inStr);
        public virtual void NotRequiredToOverride() {
            Console.WriteLine("Hello there from a virtual method.!");
        }
    }

    public class ParentSteve : Base {
        public override /*override abstract or virtual methods*/ void DoSomething(string inStr) {
            Console.WriteLine($"Steve says {inStr}");
        }
    }

    public class ParentDave : Base {
        public override /*override abstract or virtual methods*/ void DoSomething(string inStr) {
            Console.WriteLine($"Dave says {inStr}");
        }
    }
}

