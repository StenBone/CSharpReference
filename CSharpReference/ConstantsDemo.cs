using System;


namespace CSharpReference {

    /// <summary>
    /// readonly: can be changed in constructor 
    /// const: can only be initialized at declation. Acts as a static class field
    /// </summary>
    class ConstantsDemo {
        public const float PI = 3.1415926f; // acts as a static field
        public readonly string SSN;

        public ConstantsDemo(string inSSN) {
            this.SSN = ""; // can be changed multiple times in constructor
            this.SSN = inSSN; // can only be given values in the contructors

        }
    }
}
