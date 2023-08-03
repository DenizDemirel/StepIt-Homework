namespace WeaponDecoratorTask.Models;

using WeaponDecoratorTask.Models.Base;

public class Shotgun : Weapon {
    public Shotgun() {
        this.Damage = 50;
        this.Accuracy = 35;
        this.Mobility = 40;
    }
}