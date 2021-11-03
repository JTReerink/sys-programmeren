using System;
using System.Collections.Generic;
using System.Text;

namespace Les2
{
    class Enemy
    {
        public int health = 0;
        public void Damage(int amount)
        {
            health -= amount;
        }
    }
}
