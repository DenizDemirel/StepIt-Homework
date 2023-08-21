using WeaponDecoratorTask.Interfaces;

namespace WeaponDecoratorTask.Models.Base; 

public class Weapon : IPrototype<Weapon> {

    private int damage;
    private int accuracy;
    private int mobility;
    private string? weaponIconUrl;

    public virtual string? WeaponIconUrl { get => this.weaponIconUrl; set => this.weaponIconUrl = value; }
    public virtual int Damage { get => this.damage; set => this.damage = WeaponValueCondition(value); }
    public virtual int Accuracy { get => this.accuracy; set => this.accuracy = WeaponValueCondition(value); }
    public virtual int Mobility { get => this.mobility; set => this.mobility = WeaponValueCondition(value); }

    public override string ToString() => $"Damage [{this.Damage}] Accuracy [{this.Accuracy}] Mobility [{this.Mobility}]";

    public Weapon Clone() => (this.MemberwiseClone() as Weapon)!; 
    private int WeaponValueCondition(int value) {

        if (value < 0) 
            return 0;

        else if (value > 100) 
            return 100;

        return value;
    }
}
