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

namespace TowerDefense
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dictionary<int, int> positionTower1 = new Dictionary<int, int>();
            positionTower1.Add(0, 0);
            Dictionary<int, int> positionMob1 = new Dictionary<int, int>();
            positionMob1.Add(0, 0);
            Tower tower1 = new Tower("archer", "fleche", 100, 100, positionTower1, 50);
            Mob mob1 = new Mob("loup", "animal", 20, 50, positionMob1);
        }
    }
}
