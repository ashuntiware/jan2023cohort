// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Create an instance of Enemy 
Enemy badguy = new Enemy("badguy");
Enemy monster = new Enemy("monster");
Console.WriteLine(badguy.Name);
Console.WriteLine(monster.Name);

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

// Calling bad guy to perform random attack method
badguy.RandomAttack();

// Calling bad guy to perform attack against monster and the health will decrement by the chosen attack's damage amount. 
// badguy.PerformAttack(monster, fireball);



// Creating an instance of Melefighter
MeleeFighter john = new MeleeFighter("john");

//Calling Melefighter john to pefrom rage method
john.RageMethod(monster);


//Calling Melefighter john to pefrom rage method
// john.PerformAttack(monster, fireball);