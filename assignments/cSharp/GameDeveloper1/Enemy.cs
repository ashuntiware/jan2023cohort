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
        var list = new List<Attack>();
        int randAttack = random.Next(list.Count);
        Console.WriteLine(list[randAttack]);
        
    }}





