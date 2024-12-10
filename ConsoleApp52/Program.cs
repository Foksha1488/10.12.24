using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{/// <summary>
/// По номеру месяца вывести его название.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = Input("номер месяца");
            Console.WriteLine(Months(month));
            Console.ReadLine();
        }
        static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        static string Months(int month)
        {
            switch(month)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апрель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";
                default:return "Ошибка";
            }
               
        }
    }
}
