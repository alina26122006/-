using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кт
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса Vector
            Vector vector = new Vector(1, 2, 3, 4);

            // Перегруженный оператор умножения на число
            Vector result = 2.5 * vector;

            // Выводим результат
            Console.WriteLine("StartX: {0}, StartY: {1}, EndX: {2}, EndY: {3}",
                result.StartX, result.StartY, result.EndX, result.EndY);
        }
    }
}
