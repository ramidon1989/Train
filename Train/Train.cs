﻿/* Класс Train - представляет собой ООП-представление поезда.
 * Реализован как усечённый вариант кольцевого двусвязного списка. Отсутствуют методы Add,Remove и пр.
 * При создании экземпляра класса в качестве параметра конструктора указывается целочисленное значение,
 * обзначающее количество вагонов в поезде. * 
 * 
 * */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Task5
{
    /// <summary>
    /// ООП-представление поезда,состоящего из связанных между собой вагонов.
    /// </summary>
    public class Train : IEnumerable
    {
        /// <summary>
        /// Список вагонов, из которых состоит поезд.
        /// </summary>
        List<Wagon> WagonsList;
        /// <summary>
        /// Условно первый вагон.
        /// </summary>
        Wagon first;
        /// <summary>
        /// Условно последний вагон.
        /// </summary>
        Wagon tail;

        /// <summary>
        /// Количество вагонов в поезде.
        /// </summary>
        public int Count { get { return WagonsList.Count; } }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Count"> Количество вагонов в поезде </param>
        public Train(int Count)
        {
            if(Count <= 0) throw new ArgumentException("Значение должно быть больше 0", nameof(Count));

            CreateTrain(Count);
        }

        /// <summary>
        /// Создаёт поезд,состоящий из количества вагонов, указанного в параметре.
        /// </summary>
        /// <param name="Count">Количество вагонов, которые необходимо создать.</param>
        void CreateTrain(int Count)
        {
            WagonsList = new List<Wagon>();

            for(int i = 0; i < Count; i++)
            {
                Wagon wagon = new Wagon(i, Convert.ToBoolean(new Random().Next(0, 2)));
                WagonsList.Add(wagon);

                if(i == 0) continue;

                WagonsList[i - 1].Next = WagonsList[i];
                WagonsList[i].Previous = WagonsList[i - 1];
            }

            SetFirstAndTail();
        }

        /// <summary>
        /// Устанавливает первый,последний вагон и ссылки на свойста Next и Previous.
        /// </summary>
        void SetFirstAndTail()
        {
            first = WagonsList[0];
            tail = WagonsList.Count > 1 ? WagonsList[WagonsList.Count - 1] : first;
            tail.Next = first;
            first.Previous = tail;
        }

        public Wagon this[int index]
        {
            get { return WagonsList[index]; }
        }

        public IEnumerator GetEnumerator()
        {
            return WagonsList.GetEnumerator();
        }
    }
}
