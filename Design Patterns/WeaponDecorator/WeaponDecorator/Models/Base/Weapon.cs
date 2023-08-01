namespace WeaponDecorator.Models.Base; 

public class Weapon {

    private int damage;
    private int accuracy;
    private int mobility;

    public virtual int Damage { get => this.damage; set => this.damage = WeaponValueCondition(value); }
    public virtual int Mobility { get => this.mobility; set => this.mobility = WeaponValueCondition(value); }
    public virtual int Accuracy { get => this.accuracy; set => this.accuracy = WeaponValueCondition(value); }

    public string WeaponInfo => $"-Damage {this.Damage}\n-Mobility {this.Mobility}\n-Accuracy {this.Accuracy}";

    private int WeaponValueCondition(int value) {

        if (value < 0) 
            return 0;

        else if (value > 100) 
            return 100;

        return value;
    }
}
