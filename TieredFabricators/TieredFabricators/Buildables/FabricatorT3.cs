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
    public static class FabricatorT3
    {
        public static PrefabInfo Info { get; private set; }

        public static void Register()
        {
            Info = PrefabInfo.WithTechType("FabricatorT3", "Fabricator - Tier 3", "A high-tech fabricator for late-game crafting.")
                .WithIcon(SpriteManager.Get(TechType.BaseUpgradeConsole));

            var customPrefab = new CustomPrefab(Info);

            // Copy model of default fabricator
            customPrefab.SetGameObject(new CloneTemplate(Info, TechType.Fabricator));

            // Fabricator - Tier 3 Recipe
            customPrefab.SetRecipe(new RecipeData
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(TechType.PlasteelIngot, 1),
                    new Ingredient(TechType.AdvancedWiringKit, 2),
                    new Ingredient(TechType.Aerogel, 1)
                }
            });

            // Indicate that the fabricator is being built in the world
            customPrefab.SetPdaGroupCategory(TechGroup.InteriorModules, TechCategory.InteriorModule);

            customPrefab.Register();
        }
    }
}
