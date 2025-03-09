using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using Nautilus.Crafting;
using Nautilus.Handlers;
using Nautilus.Utility;
using System.Collections.Generic;
using UnityEngine;
using static CraftData;

namespace TieredFabricators.Buildables
{
    public static class FabricatorT1
    {
        public static PrefabInfo Info { get; private set; }

        public static void Register()
        {
            Info = PrefabInfo.WithTechType("FabricatorT1", "Fabricator - Tier 1", "A basic fabricator for early-tier crafting.")
                .WithIcon(SpriteManager.Get(TechType.Fabricator));

            var customPrefab = new CustomPrefab(Info);

            // Copy model of default fabricator
            customPrefab.SetGameObject(new CloneTemplate(Info, TechType.Fabricator));

            // Fabricator - Tier 1 Recipe
            customPrefab.SetRecipe(new RecipeData
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(TechType.Titanium, 2),
                    new Ingredient(TechType.WiringKit, 1)
                }
            });

            // Indicate that the fabricator is being built in the world
            customPrefab.SetPdaGroupCategory(TechGroup.InteriorModules, TechCategory.InteriorModule);

            // Регистрируем в Nautilus
            customPrefab.Register();
        }
    }
}
