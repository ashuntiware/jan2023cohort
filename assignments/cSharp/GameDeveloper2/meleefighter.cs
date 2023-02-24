public class MeleeFighter: Enemy
{
    public MeleeFighter(string name) : base("name"){
        Name = name;
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
       AttackList[index].DamageAmount += 10; // Add an additonal 10 to damamge amount
       int a = 10;
        for (int i = 0; i <= 100; a++);
            Console.WriteLine(AttackList[index].DamageAmount);

        }   
    }



