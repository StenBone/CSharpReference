using System;


namespace CSharpReference {
    class Constants {
        public readonly float PI = 3.1415926f;
        public readonly string SSN;

        Constants(string inSSN) {
            this.SSN = inSSN; // can only be given values in the contructors

        }
    }
}
