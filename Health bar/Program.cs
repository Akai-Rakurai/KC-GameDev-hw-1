string hero = ("alex");
int health = 100;
Console.WriteLine("initial health: " + health);
int Damage = (health - 20);
Console.WriteLine("Health after damage is: " + Damage);
int Boost = (Damage + 10);
Console.WriteLine("Health after boost is: " + Boost);
if (Damage > Boost)
{
    Console.WriteLine("You died");
}
else
{
    Console.WriteLine(Damage + " is less than " + Boost);
}
