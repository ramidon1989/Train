using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var rndNumber = new Random().Next(1, 1000);
            Train train = new Train(rndNumber);

            Console.WriteLine($"Количество вагонов {rndNumber} (Сгенереривано случайно)");
            Console.WriteLine(new String('-', 30));
            Console.WriteLine($"Количество вагонов, расчитанных алгоритмом равен {Observer.CalculateWagonsCount(train, new Random().Next(rndNumber))}");

            Console.ReadKey();
        }
    }
}
