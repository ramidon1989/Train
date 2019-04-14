/*Класс Observer - ОО представление наблюдателя, осуществляющего пересчёт.
 * Статический метод CalculateWagonsCount в качестве параметра принимает объект типа Train
 * и расчитывает количество вагонов.
 * Принцип работы алгоритма следующий:
 * 1. Выбираем случайный вагон и устанавливаем его в качества отправной точки(Head)
 * 2. В головном вагоне включаем свет.
 * 3. Устанавливаем объект-вагон Current - вагон который набюдатель видит в определённый момент времени.
 * 4. Устанавливаем счётчик count=0, переходим к следующему вагону и проверяем горит ли в нём свет.
 * 5. Если свет горит, то выключаем его и возвращаемся к головному
 *  вагону и проверяем горит ли теперь в нём свет.
 * 6. Если в головном вагоне свет не горит - значит мы сделали круг и нам известно количество вагонов.
 *    Выходим из цикла и возвращаем счётчик count.
 * 5. Если в головном вагоне свет горит, то переходим к пункту 3.
 * 
 * */

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
        public static int CalculateWagonsCount(Train train)
        {
            if(train == null) throw new NullReferenceException("Ссылка на объект не указывает на экземпляр объекта");

            int wagonNumber = new Random().Next(1, train.Count); // начинаем со случайно выбранного вагона

            int count = 0;
            Wagon Head = train[wagonNumber];
            Head.LightIsSwitch = true;
            Wagon Current;
            
            do
            {
                count = 0;
                Current = Head;
                do
                {
                    Current = Current.Next;
                    count++;
                } while(Current.LightIsSwitch == false);

                Current.LightIsSwitch = false;

            } while(Head.LightIsSwitch == true);

            return count;
        }
    }
}
