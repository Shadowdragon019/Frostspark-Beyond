using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace FrostsparkBeyond.Items
{
  [AutoloadEquip(EquipType.HandsOn, EquipType.HandsOff)]
	public class SpikedFireGauntlet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Increases armor penetration by 8\nAttackers also take damage\nIncreases melee knockback and inflicts fire damage on attack\n12% increased melee damage and 10% increased melee speed");
		}

		public override void SetDefaults() 
		{
            item.accessory = true;
            item.value = 350000;
            item.width = 26;
            item.height = 38;
            item.rare = ItemRarityID.Lime;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
        {
        player.kbGlove = true;
				player.meleeSpeed += 0.1f;
				player.meleeDamage += 0.12f;
				player.magmaStone = true;
				player.thorns = 1f;
        player.armorPenetration += 8;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FireGauntlet, 1);
            recipe.AddIngredient(ItemID.SharkToothNecklace, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}