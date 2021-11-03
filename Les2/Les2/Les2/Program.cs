using System;

namespace Les2
{
    class Program
    {
        //Enemy enemy = new Enemy();
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            enemy.Damage(30);
            Console.WriteLine(enemy.health);
        }
    }
}
