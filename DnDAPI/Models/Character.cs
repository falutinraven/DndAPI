using DnDAPI.Services;
using System;

namespace DnDAPI.Models
{
    public class Character
    {
        public long Id { get; set; }
        public Talent.Abilities Abilities { get; set; }
        public Talent.Skills Skills { get; set; }
        public Talent.SavingThrows SavingThrows { get; set; }
        public MiscStats MiscStats { get; set; }
        public string? CharacterName { get; set; }
        public string? Class { get; set; }
        public string? Background { get; set; }
        public string? PlayerName { get; set; }
        public string? Alignment { get; set; }
        public string? Race { get; set; }
        public int? ExperiecePoints { get; set; }
        public Inventories Inventory { get; set; }


        public Character() { }
    }

    public class Inventories
    {
        public Inventory.Currencies Money { get; set; }
        public List<Inventory.Weapon> Weapons { get; set; }
    }

    public class MiscStats
    {
        public int? Inspirations { get; set; }
        public int ProficiencyBonus { get; set; }
        public int PassivePerception { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public decimal Speed { get; set; }
        public HitPoints Health { get; set; }
        public DeathSaves DeathSavings { get; set; }
    }

    public class HitPoints
    {
        public int Max { get; set; }
        public int Current { get; set; }
        public int Temporary { get; set; }
        public int HitDice { get; set; }
        public Dice.Dices HitDiceSize { get; set; }
    }

    public class DeathSaves
    {
        public int Successes { get; set; }
        public int Failures { get; set; }
    }

}
