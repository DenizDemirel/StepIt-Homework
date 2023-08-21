namespace WeaponDecoratorTask.Models; 

using WeaponDecoratorTask.Models.Base;

public class Pistol : Weapon {
    public Pistol() {

        this.WeaponIconUrl = "/Icons/Weapons/Pistol_Icon.jpg";

        this.Damage = 20;
        this.Accuracy = 50;
        this.Mobility = 60;
    }
}
