/*  Абстрактный класс геометрическая фигура имеет передавающийся метод расчета площади
    Сделано

    Класс прямоугольник с шириной и высотой (property) Конструктор по данным параметрам
    Квадрат наслед от прямоуг. Конструктор по стороне
    Сделано 

    Круг наслед от Геом фиг. Радиус как property, конструктор по нему
    Сделано 

    Для всех настедников переопределить вирт метод Object to string, который возращает основные параметры и площадь в виде строки.
    Сделано

    Разработка интерфейса IPrint??? Содержит метод Print не приним пары и возращ войд. Для наследников
    реализовать наследование от IPrint. Переопределяемый метод Print() выводит на консоль информацию, возвращаемую 
    переопределенным методом ToString().
 
 
 */





using System;
using System.Security.Cryptography.X509Certificates;

namespace Laba_2__3sem_
{
    abstract class Program
    {
        interface IPrint
        {
            void Print();
        }
        /// <summary>
        /// Геометриеская фигура
        /// </summary>
        class Geometry_thing
        {

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
            public new virtual string ToString()
            {
                return "0";
            }
        }
        /// <summary>
        /// Прямоугольник
        /// </summary>
        class Rectangle : Geometry_thing, IPrint
        {
            public Rectangle( double a, double b)
            {
               _property1 = a;
               _property2 = b;
            }
            public override string ToString()
            {
                return "Первая сторона прямоугольника " + Convert.ToString(_property1) + " Вторая сторона " + Convert.ToString(_property2) + " Рассчетная площадь " + String.Format("{0:0.000}", calculate_area());
            }

            public void Print()
            {
                Console.WriteLine(ToString());
            }
        }
        /// <summary>
        /// Квадрат
        /// </summary>
        class Square : Rectangle, IPrint
        {
            public Square(double side) :base(side,side)
            {
               _property1 = side;
               _property2 = side;
            }

            public void Print()
            {
                Console.WriteLine(ToString());
            }

            public override string ToString()
            {
                return "Сторона квадрата " + Convert.ToString(_property1) + " Рассчетная площадь " + String.Format("{0:0.000}", calculate_area());
            }
        }
        /// <summary>
        /// Круг
        /// </summary>
        class Circle : Geometry_thing, IPrint
        {
            public Circle(double rad)
            {
               _property1 = rad;
               _property2 = rad;
            }
            public override double calculate_area()
            {
                return (base.calculate_area()/_property1*3.1415);
            }

            public void Print()
            {
                Console.WriteLine(ToString());
            }

            public override string ToString()
            {
                return "Радиус круга" + Convert.ToString(_property1) + " Рассчетная площадь " + String.Format("{0:0.000}", calculate_area());
            }
        }




        static void Main(string[] args)
        {
            Square square1 = new Square(10);
            Console.WriteLine(square1.ToString());
            square1.Print();
            
            Rectangle object1 = new Rectangle(10, 20);
            Console.WriteLine(object1.calculate_area());
            object1.Print();

            Circle object_circle = new Circle(10);
            object_circle.Print();

            double a = 102.21;

            Console.WriteLine("{0:F3}", a);
            Console.WriteLine(101.21);
        }
    }
}
