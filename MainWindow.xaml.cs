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
        
        string[] games = new string[18] { "Ball and Paddle", "Beat 'em Up", "Fighting", "Maze", "Pinball", "Platform", "FPS", "Shoot 'em up", "Stealth", "Survival", "Text", "Visual Novel", "RPG", "Racing", "Musical", "Puzzle", "Tivia", "Board/ Card" };
        string[] types = new string[9] { "Outer space", "Horror", "Action", "Medieval", "Crime", "Adventure", "Mystery", "War", "Arcade style" };
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
