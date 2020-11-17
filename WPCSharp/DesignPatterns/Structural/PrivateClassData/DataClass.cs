using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Structural
{
    public class DataClass
    {
        private int attr1;
        private int attr2;

        public DataClass(int attr1, int attr2)
        {
            this.attr1 = attr1;
            this.attr2 = attr2;
        }

        public int GetAttr1()
        {
            return attr1;
        }

        public int GetAttr2()
        {
            return attr2;
        }
    }
}
