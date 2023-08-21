using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeaponDecoratorTask.Decorators;
using WeaponDecoratorTask.Models;
using WeaponDecoratorTask.Models.Base;

namespace WeaponDecoratorTask {
    public partial class MainWindow : Window, INotifyPropertyChanged {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int CurrentWeaponIndex { get; set; }


        private string currentWeaponImageUrl;
        public string CurrentWeaponImageUrl {

            get => currentWeaponImageUrl;
            set => this.PropertyChangeMethod(out currentWeaponImageUrl, value);
        }

        private List<Weapon> weapons;
        public List<Weapon> Weapons {

            get => weapons;
            set => this.PropertyChangeMethod(out weapons, value);
        }

        private Weapon currentWeapon;
        public Weapon CurrentWeapon {

            get => currentWeapon;
            set => this.PropertyChangeMethod(out currentWeapon, value);
        }

        public MainWindow() {

            InitializeComponent();

            Weapons = new List<Weapon>() { new Pistol(), new Rifle() };
            CurrentWeaponIndex = 0;

            CurrentWeapon = Weapons[CurrentWeaponIndex].Clone();

            DataContext = this;
        }

        private void PropertyChangeMethod<T>(out T field, T value, [CallerMemberName] string propName = "") {
            field = value;

            if (this.PropertyChanged != null) {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e) {

            ChangeMoficatorsStatus(true);
            CurrentWeapon = Weapons[CurrentWeaponIndex].Clone();
        }
        private void SwapLeftButton_Click(object sender, RoutedEventArgs e) {

            if (CurrentWeaponIndex == 0)
                return;
            ChangeMoficatorsStatus(true);
            CurrentWeapon = Weapons[--CurrentWeaponIndex].Clone();
        }
        private void SwapRightButton_Click(object sender, RoutedEventArgs e) {

            if (CurrentWeaponIndex == weapons.Count - 1)
                return;
            ChangeMoficatorsStatus(true);
            CurrentWeapon = Weapons[++CurrentWeaponIndex].Clone();
        }

        private void DamageBoostButton_Click(object sender, RoutedEventArgs e) {
            CurrentWeapon = new DamageBoostDecorator(CurrentWeapon);
            this.DamageBoostButton.IsEnabled = false;
        }
        private void MobilityBoostButton_Click(object sender, RoutedEventArgs e) {
            CurrentWeapon = new MobilityBoostDecorator(CurrentWeapon);
            this.MobilityBoostButton.IsEnabled = false;
        }
        private void AccuracyBoostButton_Click(object sender, RoutedEventArgs e) {
            CurrentWeapon = new AccuracyBoostDecorator(CurrentWeapon);
            this.AccuracyBoostButton.IsEnabled = false;
        }

        private void ChangeMoficatorsStatus(bool status) {
            this.DamageBoostButton.IsEnabled = status;
            this.MobilityBoostButton.IsEnabled = status;
            this.AccuracyBoostButton.IsEnabled = status;
        }
    }
}
