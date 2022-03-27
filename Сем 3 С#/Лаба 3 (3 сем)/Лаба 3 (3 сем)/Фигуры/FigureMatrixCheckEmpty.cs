using Laba_3__3sem_;
using System;

namespace Laba_3__3sem_
{
    class FigureMatrixCheckEmpty : IMatrixCheckEmpty<Geometry_thing>
    {
        /// <summary>
        /// В качестве пустого элемента возвращается null
        /// </summary>
        public Geometry_thing getEmptyElement()
        {
            return null;
        }

        /// <summary>
        /// Проверка что переданный параметр равен null
        /// </summary>
        public bool checkEmptyElement(Geometry_thing element)
        {
            bool Result = false;
            if (element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}