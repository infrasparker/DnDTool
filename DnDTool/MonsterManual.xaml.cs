using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DnDTool
{
    /// <summary>
    /// Interaction logic for MonsterManual.xaml
    /// </summary>
    public partial class MonsterManual : Page
    {
        public ObservableCollection<Monster> monsters { get; set; }

        public MonsterManual()
        {
            InitializeComponent();
            monsters = new ObservableCollection<Monster>();
            monsters.Add(new Monster("Dragon", 12));
            this.DataContext = this;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddCreatureWindow creator = new AddCreatureWindow(this.monsters);
            creator.Show();
        }
    }
}
