using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_Momento.History;
using WPF_Momento.Model;

namespace WPF_Momento {
    /// <summary>
    /// Interaction logic for HistoryWindow.xaml
    /// </summary>
    public partial class HistoryWindow : Window, INotifyPropertyChanged {
        
        MainWindow headWindow;

        public event PropertyChangedEventHandler? PropertyChanged;
        public HistoryWindow( MainWindow headWindow ) {
            
            InitializeComponent();
            DataContext = headWindow;

            this.headWindow = headWindow;
        }

        private void Change_Button_Click( object sender, RoutedEventArgs e ) {
           if (Saves_ListView.SelectedIndex == -1) 
               return;
            headWindow.CurrentUserData.Load(Saves_ListView.Items.GetItemAt(Saves_ListView.SelectedIndex) as UserDataMemento);
            PropertyChanged?.Invoke(headWindow, new PropertyChangedEventArgs(nameof(headWindow.CurrentUserData)));
        }

        protected override void OnClosing( CancelEventArgs e ) {

            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
            headWindow.History_Button.IsEnabled = true;
        }

    }
}