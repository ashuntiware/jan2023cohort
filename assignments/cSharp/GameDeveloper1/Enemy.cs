class Enemy {
    public string EnemyName;

    public int Health;

    public List <Attack> AttackList ;

    public Enemy (string theEnemy) {
        EnemyName = theEnemy;
        Health = 100;
        AttackList = new List<Attack>();
    }
    
    public void RandomAttack() {
        var random = new Random ();
        var randomList = new List <string>{"fireball", "punch", "throw"}; // List of random Attacks
        int index = random.Next(randomList.Count); //Generates a number between 1 and 3
        Console.WriteLine(randomList[index]);
    }}





