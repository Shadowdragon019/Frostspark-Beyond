using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace FrostsparkBeyond.Items
{
	public class LivingMagnifyingGlass : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("'Show those... weaker spots!'\n15% increased critical strike chance");
		}

		public override void SetDefaults() 
		{
           item.accessory = true;
            item.value = 1925000;
            item.width = 28;
            item.height = 28;
            item.rare = ItemRarityID.Lime;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
        {
				player.meleeCrit += 15;
				player.rangedCrit += 15;
				player.magicCrit += 15;
				player.thrownCrit += 15;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MagnifyingGlass");
            recipe.AddIngredient(ItemID.EyeoftheGolem, 1);
            recipe.AddIngredient(ItemID.SoulofFright, 15);
            recipe.AddIngredient(ItemID.SoulofMight, 15);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}