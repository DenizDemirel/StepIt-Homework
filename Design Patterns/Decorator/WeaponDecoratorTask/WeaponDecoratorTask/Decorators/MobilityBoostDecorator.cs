namespace WeaponDecoratorTask.Decorators;

using WeaponDecoratorTask.Decorators.Base;
using WeaponDecoratorTask.Models.Base;

public class MobilityBoostDecorator : WeaponDecorator {
    public MobilityBoostDecorator(Weapon wrapper) : base(wrapper) {
        
        this.mobility = 15;
        this.accuracy = -10; 
    }
}
