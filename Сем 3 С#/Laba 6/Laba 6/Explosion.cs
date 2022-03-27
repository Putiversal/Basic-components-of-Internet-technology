using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_6
{
    class Explosion
    {
        public Explosion() { }
        public Explosion(int i) { }
        public Explosion(string str) { }

        public int BOOM(int x, int y) { return x * y; }
        public int Plus(int x, int y) { return x + y; }

        [NewAttribute("Описание для property1")]
        public string property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }
        private string _property1;

        public int property2 { get; set; }

        [NewAttribute(Description = "Описание для property3")]
        public double property3 { get; private set; }

        public int field1;
        public float field2; //Question Single

        /// <summary>
        /// Реализация интерфейса IComparable
        /// </summary>
        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
