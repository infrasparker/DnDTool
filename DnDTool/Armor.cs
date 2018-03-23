using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool
{
    public class Armor
    {
        public enum armorType {LIGHT, MEDIUM, HEAVY}

        public string Name { get; set; }
        public armorType type { get; set; }
        public int baseAC { get; set; }
        
        public Armor(string name)
        {
            this.Name = name;
            switch (name)
            {
                case "Padded":
                    this.type = Armor.armorType.LIGHT;
                    this.baseAC = 11;
                    break;
                case "Leather":
                    this.type = Armor.armorType.LIGHT;
                    this.baseAC = 11;
                    break;
                case "Studded Leather":
                    this.type = Armor.armorType.LIGHT;
                    this.baseAC = 12;
                    break;
                case "Hide":
                    this.type = Armor.armorType.MEDIUM;
                    this.baseAC = 12;
                    break;
                case "Chain Shirt":
                    this.type = Armor.armorType.MEDIUM;
                    this.baseAC = 13;
                    break;
                case "Scale Mail":
                    this.type = Armor.armorType.MEDIUM;
                    this.baseAC = 14;
                    break;
                case "Breastplate":
                    this.type = Armor.armorType.MEDIUM;
                    this.baseAC = 14;
                    break;
                case "Half plate":
                    this.type = Armor.armorType.MEDIUM;
                    this.baseAC = 14;
                    break;
                case "Ring Mail":
                    this.type = Armor.armorType.HEAVY;
                    this.baseAC = 14;
                    break;
                case "Chain Mail":
                    this.type = Armor.armorType.HEAVY;
                    this.baseAC = 16;
                    break;
                case "Splint":
                    this.type = Armor.armorType.HEAVY;
                    this.baseAC = 17;
                    break;
                case "Plate":
                    this.type = Armor.armorType.HEAVY;
                    this.baseAC = 18;
                    break;
                default:
                    break;
            }
        }
    }
}
