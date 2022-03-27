using System;
using System.Collections.Generic;
using System.Text;

//7.Реализовать класс «SimpleStack» на основе односвязного списка. Класс
//    SimpleStack наследуется от класса SimpleList (проект SimpleListProject).
//    Необходимо добавить в класс методы:
//•	public void Push(T element) – добавление в стек;
//•	public T Pop() – чтение с удалением из стека.

namespace FigureCollections
{
    class MySimpleStack<T> : SimpleList<T> where T : IComparable
    {
        //public void Push(T element)
        //{
        //    SimpleListItem<T> newItem = new SimpleListItem<T>(element);
        //    this.Count++;

        //    //Добавление первого элемента
        //    if (this.stack_last == null)
        //    {
        //        this.stack_last = newItem;
        //    }
        //    //Добавление следующих элементов
        //    else
        //    {
        //        //Присоединение элемента к цепочке
        //        newItem.next = this.stack_last;
        //        this.stack_last = newItem;
        //    }
        //    Count++;
        //}
        public void Push(T element)
        {
            //Добавление в конец списка уже реализовано 
            Add(element);
        }
        public T Pop()
        {
            T Result = default(T);
            if (this.Count == 0)
            {
                return Result;
            }
            else if (this.Count == 1)
            {
                Result = this.first.data;
                //обнуляются указатели начала и конца списка
                this.first = null;
                this.last = null;
                Count--;
            }
            else
            {
                //Поиск предпоследнего элемента
                SimpleListItem<T> newLast = this.GetItem(this.Count - 2);
                //Чтение значения из последнего элемента
                Result = newLast.next.data;
                //предпоследний элемент считается последним
                this.last = newLast;
                //последний элемент удаляется из списка
                newLast.next = null;
                Count--;
            }
            return Result;
        }
        protected SimpleListItem<T> stack_last = null;



    }
}
