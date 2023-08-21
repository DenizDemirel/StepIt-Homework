namespace WeaponDecoratorTask.Decorators;

using WeaponDecoratorTask.Decorators.Base;
using WeaponDecoratorTask.Models.Base;

public class DamageBoostDecorator : WeaponDecorator {
    public DamageBoostDecorator(Weapon wrapper) : base(wrapper) {

        this.damage = 12;
        this.mobility = -10;
    }
}