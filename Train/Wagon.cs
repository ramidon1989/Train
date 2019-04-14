using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    /// <summary>
    /// Представляет ООП-представление вагона поезда.
    /// </summary>
    public class Wagon
    {
        /// <summary>
        /// True - если свет включен, в противном случае False.
        /// </summary>
        public bool LightIsSwitch { get; set; }
        /// <summary>
        /// Номер вагона.
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Ссылка на предыдущий вагон.
        /// </summary>
        public Wagon Previous { get; set; }
        /// <summary>
        /// Ссылка на следующий вагон.
        /// </summary>
        public Wagon Next { get; set; }

        public Wagon(int WagonNumber, bool Light)
        {
            Number = WagonNumber;
            LightIsSwitch = Light;
        }
        public override string ToString()
        {
            var lightSwitchState = LightIsSwitch ? "включен" : "выключен";
            return $"Вагон номер {Number},свет {lightSwitchState}";
        }
    }
}
