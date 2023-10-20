public class Fighters
{

public int health = 100;
public bool isAlive;
public Weapon weapon;
public string name;

public void Attack(Fighters target)
{
    if damageamage = weapon.GetDamage();
    target.health -=Damage;
    target.health = Math.Max(0, target.health);
    Console.WriteLine($"{name} gör {Damage} skada på {target.name}");
}
}
