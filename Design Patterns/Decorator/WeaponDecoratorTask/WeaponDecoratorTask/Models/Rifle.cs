namespace WeaponDecoratorTask.Models;

using WeaponDecoratorTask.Models.Base;

public class Rifle : Weapon {
    public Rifle() {
        this.Damage = 65;
        this.Accuracy = 80;
        this.Mobility = 30;
    }
}
