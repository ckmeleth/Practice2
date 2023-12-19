using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1


            string userName = "Денисов Денис Александрович";
            int ageNumber = 19;
            string emailAdress = "denisovdenis@yandex.ru";
            double progPoints = 95;
            double physPoints = 81;
            double mathPoints = 84;

            

            Console.WriteLine($"Ф.И.О.: {userName}");
            Console.ReadKey();

            Console.WriteLine($"Возраст: {ageNumber}");
            Console.ReadKey();

            Console.WriteLine($"Почта: {emailAdress}");
            Console.ReadKey();

            Console.WriteLine($"Баллы по программированию: {progPoints}");
            Console.WriteLine($"Баллы по физике: {physPoints}");
            Console.WriteLine($"Баллы по математике: {mathPoints}");
            Console.ReadKey();


            //Задание 2

            double sumPoints = progPoints + physPoints + mathPoints;
            double averagePoints = sumPoints / 3;

            Console.WriteLine($"Среднее арифметическое всех баллов: {averagePoints}");
            Console.ReadKey();


        }
    }
}
