// Health starts at a default of 120
// Attacks:
// Punch, 20 damage
// Kick, 15 damage
// Tackle, 25 damage
// Rage method - The fighter performs a random attack from its AttackList, but the attack deals 10 extra damage
// Hint: How will you handle updating the DamageAmount of your attack when you perform the attack?

// Attack fireball = new Attack("fireball", 20);
// Console.WriteLine(fireball.AttackName);

public class MeleeFighter: Enemy
{
    public MeleeFighter(string name) : base("name"){
        Health = 120;
        Attack kick = new Attack("kick", 15); // Created Attacks
        Attack tackle = new Attack("tackle", 25);
        Attack punch = new Attack("punch", 20);
        this.AttackList.Add(punch);
        this.AttackList.Add(kick);
        this.AttackList.Add(tackle);

    }
    public void RageMethod (Enemy Target) {
         
        var random = new Random ();
        int index = random.Next(AttackList.Count); //Generates a number between 1 and 3
        Console.WriteLine(AttackList[index]);
        AttackList[index].DamageAmount
    }
    

}


