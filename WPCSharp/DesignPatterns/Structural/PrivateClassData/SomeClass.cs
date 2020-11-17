using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural
{
    class SomeClass
    {
        //private DataClass dataClass;

        private int Attr1 { get; }
        private int Attr2 { get; }
        public SomeClass(int attr1, int attr2)
        {
            Attr1 = attr1;
            Attr2 = attr2;
            //dataClass = new DataClass(attr1, attr2);
        }

        public override string ToString()
        {
            //return $"{dataClass.GetAttr1()} {dataClass.GetAttr2()}";
            return $"{Attr1} {Attr2}";
        }
    }
}
