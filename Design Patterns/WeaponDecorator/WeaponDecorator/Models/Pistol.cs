using WeaponDecorator.Models.Base;

namespace WeaponDecorator.Models; 

public class Pistol : Weapon {
    public Pistol() {
        this.Damage = 20;
        this.Accuracy = 60;
        this.Mobility = 60;
    }
}
