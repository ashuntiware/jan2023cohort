
public class MagicCaster : Enemy
{
     public MagicCaster(string name) : base ("name"){
        Health = 80;
        Attack fireball = new Attack("fireball",25); // Created Attacks
        Attack bolt = new Attack("bolt", 20);
        Attack strike = new Attack("strike", 10);
        this.AttackList.Add(fireball);
        this.AttackList.Add(bolt);
        this.AttackList.Add(strike);
     }
        public void HealMethod ()
        {
            
        //Heal method - The fighter heals a targeted Enemy character for 40 health and displays the new health at the end
            

        }
}