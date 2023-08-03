namespace WeaponDecoratorTask.Decorators;

using WeaponDecoratorTask.Decorators.Base;
using WeaponDecoratorTask.Models.Base;

public class ScopeDecorator : WeaponDecorator {
    public ScopeDecorator(Weapon wrapper) : base(wrapper) {

        this.accuracy = 40;
        this.mobility = -10;
    }
}
