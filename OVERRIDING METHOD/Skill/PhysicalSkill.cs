using System;

namespace GameOverrideDemo
{
public class PhysicalSkill : Skill
{
    private float critRate;

    public PhysicalSkill()
    {
        critRate = 0.1f;
        Console.WriteLine("----> konstruktor default PhysicalSkill <----");
    }
    public PhysicalSkill(float critRate, string name, float power, float cost)
     : base(name, power, cost)
    {
        Console.WriteLine("----> Konstruktor berparameter PhysicalSkill <----");
        this.critRate = critRate;
    }
    public override float CalculateDamage()
    {
        Console.WriteLine("[PhysicalSkill.CalculateDamage] Menghitung damage fisik dengan critical hit... ");
        float damage = basePower * (1 + critRate);
        return damage;
    }
    
        public float CalculateDamage(bool isBacktab)
        {
            Console.WriteLine($"[PhysicalSkill.CalculateDamage] Menghitung Damage fisik dengan backstab: {isBacktab}");
            float damage = basePower * (1 + critRate);
            if (isBacktab)
            damage *= 1.5f;
            return damage;
        }

    public new void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("CRIT RATE    :" + (critRate * 100) + "%");
            Console.WriteLine("======================");
        }

    }
}