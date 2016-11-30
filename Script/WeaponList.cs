using System.Collections.Generic;
using system;
public class WeaponList {
    public List<Weapon> listOfWeapons 
    public void RunList () {
    listOfWeapons = new List <Weapon>();
    ChangeList("Hammer", 10);
    ChangeList("Club", 20);
    ChangeList("Sword", 40);
    GetListOfWeapons();
}

private void ChangeList () {
    Weapon newWeapon = new Weapon();
    newWeapon.name = name;
    newWeapon.power = power);
    listOfWeapons.Add(newWeapon);


    }
}

private void GetListOfWeapons () {
    Console.WriteLine(listOfWeapons.Count);
    foreach(Weapon weapon in listOfWeapons) {
        Console.WriteLine(weapon.name + " is the name of your weapon.");
        Console.WriteLine(weapon.power + " is the power of your weapon.");
    }
}