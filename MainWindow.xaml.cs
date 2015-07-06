using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RandomGameGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string[] games = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "textFiles\\games.txt");
        string[] types = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "textFiles\\types.txt");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            string selectGame = games[rand.Next(0, games.Length)];
            string selectType = types[rand.Next(0, types.Length)];

            gameBox.Text = selectGame.ToString();
            typeBox.Text = selectType.ToString();
        }
    }
}
