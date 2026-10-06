namespace GameOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO OVERRIDING & OVERRIDING (GAME SKILLS) ===\n");

            
            PhysicalSkill slash = new PhysicalSkill(0.3f, "Slash", 50f, 15f);
            slash.DisplaySkillInfo();

        Console.WriteLine("\n--- Menguji overloding Method ---");

            float dmg1 = slash.CalculateDamage();
            Console.WriteLine("Damage (tanpa parameter) : " + dmg1);

            float dmg2 = slash.CalculateDamage(2.0f);
             Console.WriteLine("Damage (multiplier 2.0f) : " + dmg2);

            float dmg3 = slash.CalculateDamage(1.5f,20f);
             Console.WriteLine("Damage (multiplier 1.5f, 20f) : " + dmg3);

            float dmg4 = slash.CalculateDamage("Piercing");
             Console.WriteLine("Damage (tipe piercing) : " + dmg4);
           
            float dmg5 = slash.CalculateDamage("blont");
             Console.WriteLine("Damage (backstab true) : " + dmg4);

            Console.ReadKey();
        }
    }
}