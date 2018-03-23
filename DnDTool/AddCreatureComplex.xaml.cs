using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddCreatureSimple.xaml
    /// </summary>
    public partial class AddCreatureComplex : Page
    {
        private ObservableCollection<Monster> monsters;

        public int acValue { get; set; }
        public int hpValue { get; set; }

        public List<Armor> armors { get; set; }
        public List<string> hitDice { get; set; }

        public AddCreatureComplex(ObservableCollection<Monster> monsters)
        {
            InitializeComponent();
            this.monsters = monsters;
            armors = new List<Armor>();
            armors.Add(new Armor("Padded"));
            armors.Add(new Armor("Leather"));
            armors.Add(new Armor("Studded Leather"));
            armors.Add(new Armor("Hide"));
            armors.Add(new Armor("Chain Shirt"));
            armors.Add(new Armor("Scale Mail"));
            armors.Add(new Armor("Breastplate"));
            armors.Add(new Armor("Half Plate"));
            armors.Add(new Armor("Ring Mail"));
            armors.Add(new Armor("Chain Mail"));
            armors.Add(new Armor("Splint"));
            armors.Add(new Armor("Plate"));

            hitDice = new List<string>();
            hitDice.Add("d4");
            hitDice.Add("d6");
            hitDice.Add("d8");
            hitDice.Add("d10");
            hitDice.Add("d12");
            hitDice.Add("d20");
            this.DataContext = this;
        }

        public void Create_Click(object sender, RoutedEventArgs e)
        {
            monsters.Add(new Monster("Goo", 1));
            Window.GetWindow(this).Close();
        }

        public void Numeric_Only(object sender, TextCompositionEventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            e.Handled = !reg.IsMatch(e.Text);
        }

        public void Armor_Change(object sender, SelectionChangedEventArgs e)
        {
            Armor armor = ArmorSelector.SelectedValue as Armor;
            this.acValue = armor.baseAC;
            AC.Text = acValue.ToString();
        }

        public void AC_Change(object sender, TextChangedEventArgs e)
        {
            if (AC.Text == "")
                this.acValue = 0;
            else
                this.acValue = int.Parse(AC.Text);
        }

        public void HD_Change(object sender, RoutedEventArgs e)
        {
            int amt = 0;
            if (amtHD.Text != "")
                amt = int.Parse(amtHD.Text);

            switch (hitDiceType.SelectedValue)
            {
                case "d4":
                    this.hpValue = (int)Math.Floor(2.5 * amt);
                    break;
                case "d6":
                    this.hpValue = (int)Math.Floor(3.5 * amt);
                    break;
                case "d8":
                    this.hpValue = (int)Math.Floor(4.5 * amt);
                    break;
                case "d10":
                    this.hpValue = (int)Math.Floor(5.5 * amt);
                    break;
                case "d12":
                    this.hpValue = (int)Math.Floor(6.5 * amt);
                    break;
                case "d20":
                    this.hpValue = (int)Math.Floor(10.5 * amt);
                    break;
                default:
                    break;
            }

            HP.Content = this.hpValue;
        }

        private string scoreToMod(string s)
        {
            int score = 10;
            if (s != "")
            {
                score = int.Parse(s);
            }
            int mod = (score - 10) / 2;

            if (mod < 0)
                return mod.ToString();
            else
                return "+" + mod.ToString();
        }

        public void STR_Change(object sender, TextChangedEventArgs e)
        {
            strMod.Content = scoreToMod(str.Text);
        }

        public void DEX_Change(object sender, TextChangedEventArgs e)
        {
            dexMod.Content = scoreToMod(dex.Text);
        }

        public void CON_Change(object sender, TextChangedEventArgs e)
        {
            conMod.Content = scoreToMod(con.Text);
        }

        public void INT_Change(object sender, TextChangedEventArgs e)
        {
            intMod.Content = scoreToMod(int_.Text);
        }

        public void WIS_Change(object sender, TextChangedEventArgs e)
        {
            wisMod.Content = scoreToMod(wis.Text);
        }

        public void CHA_Change(object sender, TextChangedEventArgs e)
        {
            chaMod.Content = scoreToMod(cha.Text);
        }
    }
}
