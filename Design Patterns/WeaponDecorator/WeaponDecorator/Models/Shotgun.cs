using WeaponDecorator.Models.Base;

namespace WeaponDecorator.Models;

public class Shotgun : Weapon {
    public Shotgun() {
        this.Damage = 40;
        this.Accuracy = 35;
        this.Mobility = 50;
    }
}