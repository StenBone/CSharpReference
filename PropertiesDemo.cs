using System;

namespace CSharpReference
{
    /// <summary>
    /// Properties offer a shorter syntax for encapsulating fields.
    /// </summary>
    class PropertiesDemo
    {
        #region Fields
        private string field = "dumb field";
        public string getField() { return field; }
        public void setField(string inField) { this.field = inField; }
        #endregion

        private string property = "property value"; // This is a backing field. It backs the property.
        // public access to property
        public string Property {
            get {
                return property;
            }
            set {
                if(!String.IsNullOrEmpty(value)) {
                    property = value; // value is implicit
                }
            }
        }

        // it is by convention that public variables and methods start with an upper case letter
        public string AutoProperty { get; private set; } // can't write to property from outside the class 
    }
}
