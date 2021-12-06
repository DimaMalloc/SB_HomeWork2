using System;

namespace SB_HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.Создание переменных и вывод

            string FistName = "Александр"; //Ф.И.О.
            string SecondName = "Сергеевич";
            string SurName = "Суворов";
            byte age = 34; //Возраст
            string email = "suvorov@mail.ru";  //Email
            double prog_score = 19.2; //Баллы по программированию
            double math_score = 24;  //Баллы по математике
            double physics_score = 16;//Баллы по физике

            //форматирование
            string newPattern = "Имя: {0} \nОтчество: {1} \nФамилия: {2} \nВозраст: {3} \nEmail: {4} \nБаллы по программированию: {5:000.00} \nБаллы по математике: {6:000.00} \nБаллы по физике: {7:000.00}";
            Console.WriteLine("Форматирование");
            Console.WriteLine(newPattern,
                              FistName,
                              SecondName,
                              SurName,
                              age,
                              email,
                              prog_score,
                              math_score,
                              physics_score);

            Console.ReadKey();

            //интерполяция
            //Console.WriteLine("Интерполяция");
            //Console.WriteLine($"Имя: {FistName} \nОтчество: {SurName} \nФамилия: {SurName} \nВозраст: {age} \nEmail: {email} \nБаллы по программированию: {prog_score} \nБаллы по математике: {math_score} \nБаллы по физике: {physics_score}");

            //Console.ReadKey();

            //Задание 2. Реализация подсчёта количества баллов по всем предметам

            double total_sore; //Создайте переменную под сумму баллов по всем предметам.
            total_sore = prog_score + math_score + physics_score; //Посчитайте сумму баллов.
            Console.WriteLine($"Cумма баллов по всем предметам: {total_sore}"); //сумма баллов по всем предметам

            Console.ReadKey();

            double avg_score; //Создайте переменную под средний балл.
            avg_score = (total_sore / 3); //Рассчитайте среднее арифметическое баллов.
            Console.WriteLine($"Среднее арифметическое баллов: {avg_score}"); //среднее арифметическое баллов

            Console.ReadKey();

        }
    }
}
