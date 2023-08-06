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

        [Tooltip("Supports a diferent Form List, a Container, or Level List\nIf you use a Level List its recomended to set it to Use All.")]
        public FormKey AddBooksToThis = FormKey.Factory("000D63:Add Stuff By FormList.esp");

        [Tooltip("Add Specific Spell from FormKey, not the Spell Tome.")]
        public HashSet<FormKey> DirectSpells = new();

    }


}
