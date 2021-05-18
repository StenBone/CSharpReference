﻿using System;


namespace CSharpReference {
    class ConstantsDemo {
        public const float PI = 3.1415926f; // acts as a static field
        public readonly string SSN;

        ConstantsDemo(string inSSN) {
            this.SSN = ""; // can be changed multiple times in constructor
            this.SSN = inSSN; // can only be given values in the contructors

        }
    }
}