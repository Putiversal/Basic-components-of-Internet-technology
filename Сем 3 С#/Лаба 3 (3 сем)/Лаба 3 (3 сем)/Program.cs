/*
1.	Программа должна быть разработана в виде консольного приложения на языке C#.
    Сделано)))

2.	Создать объекты классов «Прямоугольник», «Квадрат», «Круг».
    Ну допустим, ок.

3.	Для реализации возможности сортировки геометрических фигур для класса
    «Геометрическая фигура» добавить реализацию интерфейса IComparable.
    Сортировка производится по площади фигуры.
    Сделано+++

4.	Создать коллекцию класса ArrayList. Сохранить объекты в коллекцию.
    Отсортировать коллекцию. Вывести в цикле содержимое коллекции. 
    Сделано+++

5.	Создать коллекцию класса List<Figure>. Сохранить объекты в коллекцию. 
    Отсортировать коллекцию. Вывести в цикле содержимое коллекции.
    Сделано+++

6.	Модифицировать класс разреженной матрицы (проект SparseMatrix) для 
    работы с тремя измерениями – x,y,z. Вывод элементов в методе ToString()
    осуществлять в том виде, который Вы считаете наиболее удобным. Разработать
    пример использования разреженной матрицы для геометрических фигур.
    Сделано+++

7.	Реализовать класс «SimpleStack» на основе односвязного списка. Класс
    SimpleStack наследуется от класса SimpleList (проект SimpleListProject).
    Необходимо добавить в класс методы:
•	public void Push(T element) – добавление в стек;
•	public T Pop() – чтение с удалением из стека.
    Сделано+++

8.	Пример работы класса SimpleStack реализовать на основе геометрических фигур.

 
 */




using FigureCollections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3__3sem_
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Square square1 = new Square(6);
            Rectangle rectangle1 = new Rectangle(7, 4);

            Console.WriteLine("\nArrayList");
            ArrayList array1 = new ArrayList();
            array1.Add(circle1);
            array1.Add(square1);
            array1.Add(rectangle1);

            foreach (var x in array1) Console.WriteLine(x);

            Console.WriteLine("\nArrayList - сортировка");

            array1.Sort();
            
            foreach (var x in array1) Console.WriteLine(x);

            Console.WriteLine("\nList<Geometry_thing>");
            List<Geometry_thing> array2 = new List<Geometry_thing>();
            array2.Add(circle1);
            array2.Add(square1);
            array2.Add(rectangle1);

            foreach (var x in array2) Console.WriteLine(x);

            array2.Sort();

            Console.WriteLine("\nSorted List<Geometry_thing>");
            foreach (var x in array2) Console.WriteLine(x);

            Console.WriteLine("\nМатрица");
            Matrix<Geometry_thing> matrix = new Matrix<Geometry_thing>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = circle1;
            matrix[1, 2, 1] = square1;
            matrix[2, 1, 2] = rectangle1;
            Console.WriteLine(matrix.ToString());

            //++++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine("\nСтек");

            SimpleStack<Geometry_thing> stack = new SimpleStack<Geometry_thing>();
            //добавление данных в стек
            stack.Push(circle1);
            stack.Push(square1);
            stack.Push(rectangle1);
            //чтение данных из стека
            while (stack.Count > 0)
            {
                Geometry_thing f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.ReadLine();

        }
    }
}
