using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {/// <summary>
     /// Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
     /// </summary>
     /// <param name="args"></param>


        static void Main(string[] args)
        {
            int day = Input("Номер дня");
            Console.WriteLine(Days(day));
            Console.ReadKey();
        }
        static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        static string Days(int day)
        {
            switch (day)
            {
                case 1: return "Пон";
                case 2: return "Вто";
                case 3: return "Сре";
                case 4: return "Чет";
                case 5: return "Пят";
                case 6: return "Суб";
                case 7: return "Вос";
                default: return "Ош";
            }
        }
    }
    }


