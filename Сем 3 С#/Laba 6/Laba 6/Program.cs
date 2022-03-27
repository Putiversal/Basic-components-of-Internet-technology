using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    

    delegate double BigOrSmall(int p1, double p2);
    class Program
    {
        static double Big(int p1, double p2) { return p1 * p2; }
        static double Small(int p1, double p2) { return p1 + p2; }

        static void BigOrSmallMethodFunc(string str, int i1, double i2, Func<int, double, double> BigOrSmallParam)
        {
            double Result = BigOrSmallParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void BigOrSmallMethod(string str, int i1, double i2, BigOrSmall BigOrSmallParam)
        {
            double Result = BigOrSmallParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void Main(string[] args)
        {
            BigOrSmallMethod("Большой взрыв! ", 10, 10, Big);
            BigOrSmallMethod("Маленький взрыв... ", 10, 10, Big);

            int i1 = 10;
            double i2 = 10;

            BigOrSmallMethod("Создание экземпляра делегата на основе лямбда-выражения 1 (Small): ", i1, i2,
                (x, y) =>
                {
                    return x + y;
                }
                );

            BigOrSmallMethod("Создание экземпляра делегата на основе лямбда-выражения 2 (Big): ", i1, i2,
                (int x, double y) =>
                {
                    double z = x * y;
                    return z;
                }
                );

            BigOrSmallMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 3 (Small): ", i1, i2, (x, y) => x + y);

            Action<int, double> a1 = (x, y) => { Console.WriteLine("{0} + {1} = {2}", x, y, x + y); };
            Action<int, double> a2 = (x, y) => { Console.WriteLine("{0} - {1} = {2}", x, y, x - y); };
            Action<int, double> group = a1 + a2;
            group(10, 10);

            Action<int, double> group2 = a1;
            Console.WriteLine("Добавление вызова метода к групповому делегату");
            group2 += a2;
            group2(10, 10);
            Console.WriteLine("Удаление вызова метода из группового делегата");
            group2 -= a1;
            group2(10, 10);


            Console.WriteLine("\n2 ЧАСТЬ ЛАБЫ");

            TypeInfo();
            AttributeInfo();
            InvokeMemberInfo();
        }
        static void TypeInfo()
        {
            Explosion obj = new Explosion();
            Type t = obj.GetType();

            //другой способ
            //Type t = typeof(ForInspection);

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }
        }
        static void AttributeInfo()
        {
            Type t = typeof(Explosion);
            Console.WriteLine("\nСвойства класса Explosion с атрибутами:");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(NewAttribute), out attrObj))
                {
                    NewAttribute attr = attrObj as NewAttribute;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
        }
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            bool Result = false;
            attribute = null;

            //Поиск атрибутов с заданным типом
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
            {
                Result = true;
                attribute = isAttribute[0];
            }

            return Result;
        }
        static void InvokeMemberInfo()
        {
            Type t = typeof(Explosion);
            Console.WriteLine("\nВызов метода класса Explosion:");

            //Создание объекта
            //ForInspection fi = new ForInspection();
            //Можно создать объект через рефлексию
            Explosion fi = (Explosion)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });

            //Параметры вызова метода
            object[] parameters = new object[] { 10, 10 };
            //Вызов метода
            object Result = t.InvokeMember("BOOM", BindingFlags.InvokeMethod, null, fi, parameters);
            Console.WriteLine("BOOM(10,10)={0}", Result);
        }
    }
}
