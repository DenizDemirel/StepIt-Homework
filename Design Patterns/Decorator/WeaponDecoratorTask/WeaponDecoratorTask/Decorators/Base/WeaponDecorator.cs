namespace WeaponDecoratorTask.Decorators.Base;

using System;
using WeaponDecoratorTask.Models.Base;


public class WeaponDecorator : Weapon {

    protected Weapon wrapper;

    protected int damage;
    protected int accuracy;
    protected int mobility;

    public override int Damage => this.wrapper.Damage + this.damage;
    public override int Accuracy => this.wrapper.Accuracy + this.accuracy;
    public override int Mobility => this.wrapper.Mobility + this.mobility;

    public WeaponDecorator(Weapon wrapper) {
        this.wrapper = wrapper;
    }
}
