using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Utility;
using System.Collections.Generic;
using UnityEngine;
using static CraftData;

namespace TieredFabricators.Buildables
{
    public static class FabricatorT2
    {
        public static PrefabInfo Info { get; private set; }

        public static void Register()
        {
            Info = PrefabInfo.WithTechType("FabricatorT2", "Fabricator - Tier 2", "An advanced fabricator for mid-tier crafting.")
                .WithIcon(SpriteManager.Get(TechType.Workbench));

            var customPrefab = new CustomPrefab(Info);

            // Copy model of default fabricator
            customPrefab.SetGameObject(new CloneTemplate(Info, TechType.Fabricator));

            // Fabricator - Tier 2 Recipe
            customPrefab.SetRecipe(new RecipeData
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(TechType.TitaniumIngot, 1),
                    new Ingredient(TechType.AdvancedWiringKit, 1),
                    new Ingredient(TechType.ComputerChip, 1)
                }
            });

            // Indicate that the fabricator is being built in the world
            customPrefab.SetPdaGroupCategory(TechGroup.InteriorModules, TechCategory.InteriorModule);

            customPrefab.Register();
        }
    }
}
