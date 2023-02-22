// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Create an instance of Enemy 
Enemy badguy = new Enemy("badguy");
Console.WriteLine(badguy.EnemyName);

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

badguy.RandomAttack();