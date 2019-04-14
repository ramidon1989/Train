using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    /// <summary>
    /// Класс,представляющий наблюдателя.
    /// </summary>
    public class Observer
    {
        /// <summary>
        /// Считает и возвращает количество вагонов в поезде.
        /// </summary>
        /// <param name="train">Поезд, в котором необходимо посчитать вагоны.</param>
        /// <param name="wagonNumber">Случайное число,обозначающее номер вагона с которого начинается расчёт.</param>
        /// <returns></returns>
        public static int CalculateWagonsCount(Train train, int wagonNumber)
        {
            if(train == null) throw new NullReferenceException("Ссылка на объект не указывает на экземпляр объекта");
            if(wagonNumber < 0) throw new ArgumentException("Значение должно быть больше или равно 0", nameof(wagonNumber));

            int count = 0;
            Wagon Head = train[wagonNumber];
            Head.LightIsSwitch = true;
            Wagon Current = Head;

            while(Head.LightIsSwitch == true)
            {
                count = 0;
                Current = Head;
                do
                {
                    Current = Current.Next;
                    count++;
                } while(Current.LightIsSwitch == false);

                Current.LightIsSwitch = false;
            }
            return count;
        }
    }
}
