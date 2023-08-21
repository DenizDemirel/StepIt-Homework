namespace WeaponDecoratorTask.Decorators;
using WeaponDecoratorTask.Decorators.Base;
using WeaponDecoratorTask.Models.Base;

public class AccuracyBoostDecorator : WeaponDecorator {
    public AccuracyBoostDecorator(Weapon wrapper) : base(wrapper) {

        this.accuracy = 20;
        this.mobility = -10;
    }
}
