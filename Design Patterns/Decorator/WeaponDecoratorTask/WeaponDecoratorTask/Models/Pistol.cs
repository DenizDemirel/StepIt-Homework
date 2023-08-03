namespace WeaponDecoratorTask.Models; 

using WeaponDecoratorTask.Models.Base;

public class Pistol : Weapon {
    public Pistol() {
        this.Damage = 20;
        this.Accuracy = 50;
        this.Mobility = 60;
    }
}
