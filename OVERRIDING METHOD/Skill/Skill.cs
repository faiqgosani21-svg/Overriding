using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace GameOverrideDemo
{
    public class Skill
    {
        protected string? skillName;
        protected float basePower;
        protected float manaCost;

        public Skill()
        {
            skillName = "Basic Skill";
            basePower = 10f;
            manaCost = 5f;
            Console.WriteLine("----> Koseruktor default Skill <----");
        }

        public Skill(string name, float power, float cost)
        {
            Console.WriteLine("----> konstruktor berparameter Skill <----");
            skillName = name;
            basePower = power;
            manaCost = cost;
        }

        public virtual float CalculateDamage()
        {
            Console.WriteLine("[Skill.CalculateDamage] Menghitung damage dasar...");
            return basePower;
        }

        public void DisplaySkillInfo()
        {
            Console.WriteLine("SKILL NAME   : "+ skillName);
            Console.WriteLine("BASE POWER   : " + basePower);
            Console.WriteLine("NAMA COST    : " + manaCost);
        }
            public float CalculateDamage(float multipler)
        {
            Console.WriteLine($"[Skill.CalculateDamage] Menghitung damage dengan multipler:{multipler}");
            return basePower * multipler;
        }

        public float CalculateDamage(float multipler, float targetDefense)
        {
            Console.WriteLine("[Skill.CalculateDamage] Menghitung damage dengan multiplier {multipler} dan defense {targetDefense}");
            float damage = basePower * multipler;
            damage -= targetDefense * 0.5f;
            if (damage < 0) damage = 0;
            return damage;
        }

        public float CalculateDamage(string damagetype)
        {
            Console.WriteLine($"[Skill.CalculateDamage] Menghitung damage tipe: {damagetype}");
            float damage = basePower;
            if (damagetype == "piercing")
            damage *= 1.3f;
            else if (damagetype == "Blunt")
            damage *= 1.1f;
            return damage;
        
        }

    }
}
