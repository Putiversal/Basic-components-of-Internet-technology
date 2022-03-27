/*
1.	Программа должна быть разработана в виде консольного приложения на языке C#.
    Сделано)))

2.	Создать объекты классов «Прямоугольник», «Квадрат», «Круг».
    Ну допустим, ок.

3.	Для реализации возможности сортировки геометрических фигур для класса
«Геометрическая фигура» добавить реализацию интерфейса IComparable.
Сортировка производится по площади фигуры.

4.	Создать коллекцию класса ArrayList. Сохранить объекты в коллекцию.
Отсортировать коллекцию. Вывести в цикле содержимое коллекции. 

5.	Создать коллекцию класса List<Figure>. Сохранить объекты в коллекцию. 
Отсортировать коллекцию. Вывести в цикле содержимое коллекции.

6.	Модифицировать класс разреженной матрицы (проект SparseMatrix) для 
работы с тремя измерениями – x,y,z. Вывод элементов в методе ToString()
осуществлять в том виде, который Вы считаете наиболее удобным. Разработать
пример использования разреженной матрицы для геометрических фигур.

7.	Реализовать класс «SimpleStack» на основе односвязного списка. Класс
SimpleStack наследуется от класса SimpleList (проект SimpleListProject).
Необходимо добавить в класс методы:
•	public void Push(T element) – добавление в стек;
•	public T Pop() – чтение с удалением из стека.

8.	Пример работы класса SimpleStack реализовать на основе геометрических фигур.

 
 */




using System;

namespace Laba_3__3sem_
{
    /// <summary>
    /// Круг
    /// </summary>
    class Circle : Geometry_thing, IPrint
    {
        public Circle(double rad)
        {
            _property1 = rad;
            _property2 = rad;
            this.Type = "Круг";
        }
        public override double calculate_area()
        {
            return (base.calculate_area() / _property1 * 3.1415);
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Laba_3__3sem_
//{
//    class Circle : Geometry_thing, IPrint
//    {
//        /// <summary>
//        /// Ширина
//        /// </summary>
//        double radius;

//        /// <summary>
//        /// Основной конструктор
//        /// </summary>
//        /// <param name="ph">Высота</param>
//        /// <param name="pw">Ширина</param>
//        public Circle(double pr)
//        {
//            this.radius = pr;
//            this.Type = "Круг";
//        }

//        public override double calculate_area()
//        {
//            double Result = Math.PI * this.radius * this.radius;
//            return Result;
//        }

//        public void Print()
//        {
//            Console.WriteLine(this.ToString());
//        }
//    }
//}
