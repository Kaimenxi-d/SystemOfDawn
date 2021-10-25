using System;

namespace ConsoleApp1
{
    class Stoly
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Характеристика стола");
            Console.Write("Размер Стола");
            tablesize();
            form();


        }
        static public void tablesize()
        {
            int widht = 250;
            int lenght = 100;
            int height = 350;
            Console.WriteLine($"Ширина ={widht}");
            Console.WriteLine($"Длина ={lenght}");
            Console.WriteLine($"Высота ={height}");
        }
        static public void form()
        {
            string square = "Квадратный";
            string sircle = "Круглый";
            string rectangular = "Прямоугольный";
            Console.WriteLine($"Форма стола ={square}");
            Console.WriteLine($"Форма стола ={sircle}");
            Console.WriteLine($"Форма стола ={rectangular}");
        }

    }
    class MetalTable:Stoly
    {
        

    }
    class WoodTable:Stoly
    {
        


    }
    
}
