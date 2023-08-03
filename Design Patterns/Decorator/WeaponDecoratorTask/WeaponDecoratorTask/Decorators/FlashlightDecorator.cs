namespace WeaponDecoratorTask.Decorators;

using WeaponDecoratorTask.Decorators.Base;
using WeaponDecoratorTask.Models.Base;

public class FlashlightDecorator : WeaponDecorator {
    public FlashlightDecorator(Weapon wrapper) : base(wrapper) {

        this.mobility = 20;
        this.accuracy = -5; 
    }
}
