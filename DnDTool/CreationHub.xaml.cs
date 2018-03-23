﻿using System;
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

namespace DnDTool
{
    /// <summary>
    /// Interaction logic for CreationHub.xaml
    /// </summary>
    public partial class CreationHub : Page
    {
        public CreationHub()
        {
            InitializeComponent();
        }

        private void MonstersButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MonsterManual());
        }
    }
}
