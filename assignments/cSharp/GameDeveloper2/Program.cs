// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Create an instance of Enemy 
Enemy badguy = new Enemy("badguy");
Enemy monster = new Enemy("monster");
MeleeFighter john = new MeleeFighter("john");
Console.WriteLine(badguy.Name);
Console.WriteLine(monster.Name);
Console.Write(john.Name);

// Create an instance of 3 Attacks
Attack fireball = new Attack("fireball", 20);
Console.WriteLine(fireball.AttackName);

Attack punch = new Attack("punch", 10);
Console.WriteLine(punch.AttackName);

Attack throwBall = new Attack("throw ball", 15);
Console.WriteLine(throwBall.AttackName);

// Add these Attacks to your Enemy instance's Attack List
badguy.AttackList.Add(fireball);
badguy.AttackList.Add(punch);
badguy.AttackList.Add(throwBall);
monster.AttackList.Add(fireball);
monster.AttackList.Add(punch);
monster.AttackList.Add(throwBall);


badguy.RandomAttack();

badguy.PerformAttack(monster, fireball);

john.RageMethod();

john.PerformAttack(monster, fireball);