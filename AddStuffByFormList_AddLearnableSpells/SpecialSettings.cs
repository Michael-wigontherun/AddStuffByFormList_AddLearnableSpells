using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStuffByFormList_AddLearnableSpells
{
    public class SpecialSettings
    {
        [Tooltip("Select Mod Names to add all Learnable Spells based off Spell Tomes.")]
        public HashSet<ModKey> LearnableSpellModNames = new();

        [Tooltip("Half Cost Perks for Learnable Spell Mod Names.\nIf none all will be excepted.")]
        public HashSet<FormKey> LearnableSpellModNamesValidHalfCostPerks = new();

        [Tooltip("Adds the Spell Books that was filtered out by Learnable Spell Mod Names Valid Half Cost Perks.")]
        public bool AddBooksFromLearnableSpellModNames = false;

        [Tooltip("Add Specific Spell from FormKey, not the Spell Tome.")]
        public HashSet<FormKey> DirectSpells = new();

    }


}
