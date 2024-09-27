namespace DnDAPI.Models
{
    public class Talent
    {
        public class Abilities
        {
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
        }

        public class SavingThrows
        {
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
        }

        public class Skills
        {
            public int Acrobatics { get; set; }
            public int AnimalHandling { get; set; }
            public int Arcana { get; set; }
            public int Athletics { get; set; }
            public int Deception { get; set; }
            public int History { get; set; }
            public int Insight { get; set; }
            public int Intimidation { get; set; }
            public int Investigation { get; set; }
            public int Medicine { get; set; }
            public int Nature { get; set; }
            public int Perception { get; set; }
            public int Performance { get; set; }
            public int Persuasion { get; set; }
            public int Religion { get; set; }
            public int SleightOfHand { get; set; }
            public int Stealth { get; set; }
            public int Survival { get; set; }
        }

        public class Modifiers
        {
            public Dictionary<string, bool> SkillProficiencies { get; set; }
            public Dictionary<string, bool> SkillExpertises { get; set; }
            public Dictionary<string, bool> SavingThrows { get; set; }
            public Dictionary<string, int> AbilityModifier { get; set; }
        }
    }
}
