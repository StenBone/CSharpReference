using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReference {
    /// <summary>
    /// Classes are State and Behavior
    /// Class is a Type with Methods, Properties and Fields
    /// Classes are reference types, they act as blueprints
    /// They provide abstraction for clearer implementation and self-documentation
    /// Encapsulation: hide data with access modifiers to prevent side-effects
    /// </summary>
    class ClassesDemo : NamedObject{

        public ClassesDemo(string name) : base(name) { // the inherited class has a defined constructor. Parent classes must call this constructor.
            //this.Name = name; // don't like this style, just listing here as an example
        }

        #region STATE
        string data = "some data";
        #endregion


        // TIP: write how you want to use the method first and then implement it.
        #region BEHAVIOR
        public void PerformBehavior() {
            data = "this new data";
        }


        #endregion
    }

    /// <summary>
    /// Tip: Internal is the default access specifier for classes. This class can only be accessed from it's assembly(i.e. namespace)
    /// </summary>
    public class NamedObject : object{ // everything inherits from Object. 

        public NamedObject(string inName) {
            this.Name = inName;
        }
        public string Name { get; set; }
    }

    
}
