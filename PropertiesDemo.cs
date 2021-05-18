using System;

namespace CSharpReference
{
    /**
     * Properties offer a shorter syntax for encapsulating fields.
     */
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

        public string AutoProperty { get; private set; } // can't write to property from outside the class 
    }
}
