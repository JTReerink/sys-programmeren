using System;
using System.Collections.Generic;
using System.Text;

namespace Les2
{
    class Enemy
    {
        private string name;
        private int health = 100;
        private int damage;
        private int stamina = 100;
        private int cooldown = 0;
        public void Skill(string name,int damage, int stamina, int cooldown)
        {
            this.name = name;
            this.damage = damage;
            this.stamina = stamina;
            this.cooldown = cooldown;
        }

        public int DoDamge()
        {
            if (cooldown < 0 && stamina > 20)
            {
                return damage;
            }
            return 0;
        }
    }
}
