using WeaponDecorator.Models.Base;

namespace WeaponDecorator.Models;

public class Rifle : Weapon {
    public Rifle() {
        this.Damage = 65;
        this.Accuracy = 80;
        this.Mobility = 30;
    }
}
