using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_5_algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("beş basamaklı sayıyı giriniz:");
            string sayı = (Console.ReadLine());

            string terssayı ="";

            for (int i = sayı.Length-1; i >= 0; i--)
            {
                terssayı += sayı[i];
            }
            

            if (terssayı == sayı)
            {
                Console.WriteLine("girilen sayı palindromdur");
            }
            else
            {
                Console.WriteLine("girilen sayı palindrom değildir");
            }
            Console.Read();
            
        }
    }
}
