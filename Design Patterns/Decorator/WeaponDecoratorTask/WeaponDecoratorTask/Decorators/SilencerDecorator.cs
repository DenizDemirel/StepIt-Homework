namespace WeaponDecoratorTask.Decorators;

using WeaponDecoratorTask.Decorators.Base;
using WeaponDecoratorTask.Models.Base;

public class SilencerDecorator : WeaponDecorator {

    public SilencerDecorator(Weapon wrapper) : base(wrapper) {

        this.damage = -10;
        this.mobility = 15;
    }
}