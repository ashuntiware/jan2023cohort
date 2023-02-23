public class Enemy {
    public string Name;

    public int Health;

    public List <Attack> AttackList;

    public Enemy(string name) {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }
    
    public void RandomAttack() {
        var random = new Random ();
        var randomList = new List <string>{"fireball", "punch", "throw ball"}; // List of random Attacks
        int index = random.Next(randomList.Count); //Generates a number between 1 and 3
        Console.WriteLine(randomList[index]);
    }

    public void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
       Target.Health -= ChosenAttack.DamageAmount;
    // TargetHealth will reduce by Attack Damage Amount
    Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }}



