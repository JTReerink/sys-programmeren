using System;

namespace Les2
{
    class Program
    {
        //Enemy enemy = new Enemy();
        static void Main(string[] args)
        {
            Enemy enemy1 = new Enemy();
            enemy1.Skill("Basic attack", 30, 20, 5);
        }
    }
}
