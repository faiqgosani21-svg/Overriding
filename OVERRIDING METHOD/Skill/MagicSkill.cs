using System;
using System.Net.Http.Headers;

namespace GameOverrideDemo
{
    public class Magicskill : Skill
    {
        private string elementType;

        public Magicskill()
        {
            elementType = "Normal";
            Console.WriteLine("----> Konstruktor default MagicSkill");
        }
        public Magicskill(string elementType, string name, float power, float cost)
        : base(name, power, cost)
        {
            Console.WriteLine("----> Konstruktor berparameter MagicSkill");
            this.elementType = elementType;
        }
        public override float CalculateDamage()
        {
            Console.WriteLine("[MagicSkill.CalculateDamage] Menghitung damage sihir dengan elemen...");
            float damage = basePower;
            if (elementType == "Fire")
            {
                damage *= 1.5f;
                Console.WriteLine("[MagicSkill] Bonus element Fire! Damage x1.5");
            }
            else if (elementType == "ice")
            {
                damage *= 1.2f;
                Console.WriteLine("[MagicSkill] Bonus elemen ice! Damage x1.2");
            }
            return damage;
        }
        public new void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("ELEMENT TYPE : + elementType");
            Console.WriteLine("=======================");
        }

    }
}