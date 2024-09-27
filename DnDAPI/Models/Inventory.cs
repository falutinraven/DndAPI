using DnDAPI.Services;

namespace DnDAPI.Models
{
    public class Inventory
    {
        public class Weapon
        {
            public string Name { get; set; }
            public string DamageType { get; set; }
            public Dice.Dices Dice { get; set; }
            public int DiceQuantity { get; set; }
            public bool Ranged { get; set; }
            public bool Martial { get; set; }
            public bool Finesse { get; set; }
            public bool Heavy { get; set; }
            public bool Light { get; set; }
            public bool Loading { get; set; } //Requires time to load weapon so can't use multiple actions + bonus action to use
            public int Range { get; set; }
            public bool Reach { get; set; } // Adds 5ft to your reach when you attack with it
            public bool Thrown { get; set; }
            public bool TwoHanded { get; set; }
            public bool Versatile { get; set; }
            public bool Silvered { get; set; }
            public int Weight { get; set; }
            public Currencies Value { get; set; }
        }

        public class Currencies
        {
            public int? Copper { get; set; }
            public int? Silver { get; set; }
            public int? Electrum { get; set; }
            public int? Gold { get; set; }
            public int? Platinum { get; set; }
        }
    }
}
