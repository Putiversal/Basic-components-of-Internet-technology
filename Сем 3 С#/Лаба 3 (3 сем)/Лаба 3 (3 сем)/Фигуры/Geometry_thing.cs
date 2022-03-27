using System;
using System.Collections.Generic;
using System.Text;

// Вопросы 
// 1) Обозначил свой IComparable, перестало работать
// 2) 

namespace Laba_3__3sem_
{
    class Geometry_thing : IComparable, IPrint
    {
        public string Type { get; protected set; }
        // Свойства обьекта
        protected double _property1;
        public double property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }
        protected double _property2;
        public double property2
        {
            get { return _property2; }
            set { _property2 = value; }
        }
        // Виртуальное вычисление площади
        public virtual double calculate_area()
        {
            return _property1 * _property2;
        }
        // Виртуальный перевод в стринг
        public override string ToString()
        {
            return this.Type + " площадью " + String.Format("{0:0.000}", calculate_area());
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public int CompareTo(object obj)
        {
            //Приведение параметра к типу "фигура"
            Geometry_thing p = (Geometry_thing)obj;
            //Сравнение
            if (this.calculate_area() < p.calculate_area()) return -1;
            else if (this.calculate_area() == p.calculate_area()) return 0;
            else return 1;
        }
        // Пошли перегрузки
        // Пошли перегрузки сравнения

        //public static bool operator ==(Geometry_thing left, Geometry_thing right) { return left.calculate_area() < right.calculate_area(); }
        //public static bool operator !=(Geometry_thing left, Geometry_thing right) { return left.calculate_area() < right.calculate_area(); }
        //public static bool operator ==(Geometry_thing left, object null)          { return left.calculate_area() == 0; }
        //public static bool operator !=(Geometry_thing left, object null)          { return left.calculate_area() != 0; }
        public static bool operator <(Geometry_thing left, Geometry_thing right)  { return left.calculate_area() < right.calculate_area(); }
        public static bool operator >(Geometry_thing left, Geometry_thing right)  { return left.calculate_area() > right.calculate_area(); }
        public static bool operator <=(Geometry_thing left, Geometry_thing right) { return left.calculate_area() <= right.calculate_area(); }
        public static bool operator >=(Geometry_thing left, Geometry_thing right) { return left.calculate_area() >= right.calculate_area(); }
        // Пока не до конца понимаю зачем, но для перегрузки (=) нужно переопределить и эти методы (в них тоже ничего не понимаю)
        public override bool Equals(object obj) { Geometry_thing form = (Geometry_thing)obj; return this == form; }
        public override int GetHashCode() { return this.calculate_area().GetHashCode(); }
        // Кончились методы, в которых я ничего не понимаю
    }
}
