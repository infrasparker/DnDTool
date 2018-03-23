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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace DnDTool
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class ProgramWindow : MetroWindow
    {
        private Boolean lMenuOpen = false;

        public ProgramWindow()
        {
            InitializeComponent();
        }

        private void LMenuButton_Click(object sender, RoutedEventArgs e)
        {
            String fx;
            if (lMenuOpen)
                fx = "lMenuHide";
            else
                fx = "lMenuShow";
            lMenuOpen = !lMenuOpen;

            Storyboard sb = Resources[fx] as Storyboard;
            sb.Begin(lMenu);
        }

        private void MonstersButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
