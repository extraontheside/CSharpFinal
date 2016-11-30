using System;

public class Battalion {

    public Warrior[] warriors = new Warrior[10];
    Battalion () {
        foreach (var item in warriors)
        {
            Random random = new Random();
            item.strength = random.Next(5, 10);
            Console.WriteLine ($"{item.strength} is the item strength.");
        }
    }    
    
}