using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Коллекции
{
    internal class Program
    {
        //public void Dobav()
        //{

        //    Dictionary<int, string> music = new Dictionary<int, string>() { };
        //}
        
        static void Main(string[] args)
        {
            //List<string> gruppa = new List<string>()
            //{
            //"Илья",
            //"Рома",
            //"Анна",
            //"Лиза",
            //"Денис",
            //"Миша"
            //};
            //foreach (var name in gruppa[2])
            //{
            //    Console.Write(name);
            //}
            Console.WriteLine("****Каталог музыкальных компакт дисков****");
            Console.WriteLine();
            Console.WriteLine();
            //Вывод дисков
            Dictionary< int, string> disc = new Dictionary<int,string>()
            {
                { 1, "Sad" },
                { 2, "Mad" },
                { 3, "Joy" },
                { 4, "Illaoi" }
            };
            foreach(var name in disc)
            {
                Console.Write(name);
            }
            Console.WriteLine();
            //Песни альбома Sad
            Dictionary<int, string> Sad = new Dictionary<int, string>()
                {
                    { 1, "Дождь" },
                    { 2, "Осень" }
                };
            //Песни альбома Mad
            Dictionary<int, string> Mad = new Dictionary<int, string>()
                {
                    { 1, "Шок" },
                    { 2, "Раш" }
                };
            //Песни альбома Joy
            Dictionary<int, string> Joy = new Dictionary<int, string>()
                {
                    { 1, "Смех" },
                    { 2, "Радость" }
                };     
            //Выво песен
            for( ; ; )
            {
                Console.WriteLine("Выберите диск для просмотра песен");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        foreach (var name in Sad)
                        {
                            Console.Write(name);
                        }
                        break;
                    case 2:
                        foreach (var name in Mad)
                        {
                            Console.Write(name);
                        }
                        break;
                    case 3:
                        foreach (var name in Joy)
                        {
                            Console.Write(name);
                        }
                        break;
                    default:
                        Console.WriteLine("Такого диска нет");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            

            Console.ReadKey();
        }

        
    }
}
