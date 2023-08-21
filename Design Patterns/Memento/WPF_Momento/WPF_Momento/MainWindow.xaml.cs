using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Imaging;
using WPF_Momento.History;
using WPF_Momento.Model;

namespace WPF_Momento {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged {

        public event PropertyChangedEventHandler? PropertyChanged;
        private HistoryWindow historyAuxiliaryWindow;

        private UserData currentUserData;

        public ObservableCollection<UserDataMemento> DataHistory { get; set; }
        public UserData CurrentUserData {
            get => currentUserData;
            set {
                currentUserData = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentUserData)));
            }

        }
        private UserDataHistory history;


        public HistoryWindow HistoryAuxiliaryWindow {

            get => historyAuxiliaryWindow;
            set {
                historyAuxiliaryWindow = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HistoryAuxiliaryWindow)));
            }
        }


        public MainWindow() {

            InitializeComponent();
            this.DataContext = this;

            HistoryAuxiliaryWindow = new HistoryWindow(this);

            DataHistory = new ObservableCollection<UserDataMemento>();

            CurrentUserData = new UserData();
            history = new UserDataHistory(CurrentUserData, DataHistory);
        }


        private void Undo_Button_Click(object sender, RoutedEventArgs e) {
            history.Undo();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentUserData)));
        }
        private void Redo_Button_Click(object sender, RoutedEventArgs e) {
            history.Redo();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentUserData)));

        }


        private void History_Button_Click(object sender, RoutedEventArgs e) {

            this.History_Button.IsEnabled = false;
            HistoryAuxiliaryWindow.Visibility = Visibility.Visible;
        }
        private void Save_Button_Click(object sender, RoutedEventArgs e) {

            history.Save();
            MessageBox.Show("User info is successfully saved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SelectImage_Button_Click( object sender, RoutedEventArgs e ) {

            OpenFileDialog op = new OpenFileDialog();

            op.Title = "Select a picture";
            op.Filter = 
                       "All supported graphics|*.jpg;*.jpeg;*.png|" +
                       "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                       "Portable Network Graphic (*.png)|*.png";

            if (op.ShowDialog() == true) 
                ProfilePicture_Image.Source = new BitmapImage(new Uri(op.FileName));
        }
        protected override void OnClosing( CancelEventArgs e ) => Environment.Exit(0);
    }
}
