using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace FrostsparkBeyond.Items
{
	public class MagnifyingGlass : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("MagnifyingGlass"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Show those weak spots!'\n5% increased critical strike chance");
		}

		public override void SetDefaults() 
		{
           item.accessory = true;
            item.value = 25000;
            item.width = 28;
            item.height = 28;
            item.rare = ItemRarityID.White;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
        {
				player.meleeCrit += 5;
				player.rangedCrit += 5;
				player.magicCrit += 5;
				player.thrownCrit += 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 15);
            recipe.AddIngredient(ItemID.Glass, 25);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}