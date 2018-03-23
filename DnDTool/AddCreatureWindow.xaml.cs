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
using System.Windows.Shapes;

namespace DnDTool
{
    /// <summary>
    /// Interaction logic for AddCreatureWindow.xaml
    /// </summary>
    public partial class AddCreatureWindow : Window
    {
        private ObservableCollection<Monster> monsters;

        public AddCreatureWindow(ObservableCollection<Monster> monsters)
        {
            InitializeComponent();
            this.monsters = monsters;
            displayFrame.Navigate(new AddCreatureComplex(monsters));
        }
    }
}
