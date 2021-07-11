using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace FrostsparkBeyond.Items
{
  [AutoloadEquip(EquipType.HandsOn, EquipType.HandsOff, EquipType.Shoes, EquipType.Waist)]
	public class InfernoNinjaGear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Increases armor penetration by 8\nAttackers take damage\nIncreases melee knockback and inflicts fire damage on attack\n15% increased melee damage and speed\nAllows the ability to climb walls and dash\nGives a chance to dodge attacks");
		}

		public override void SetDefaults() 
		{
            item.accessory = true;
            item.value = 850000;
            item.width = 26;
            item.height = 38;
            item.rare = ItemRarityID.Yellow;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
        {
				player.blackBelt = true;
				player.dash = 1;
				player.spikedBoots = 2;
        player.kbGlove = true;
				player.meleeSpeed += 0.15f;
				player.meleeDamage += 0.15f;
				player.magmaStone = true;
				player.thorns = 1.5f;
        player.armorPenetration += 8;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MasterNinjaGear, 1);
            recipe.AddIngredient(mod, "SpikedFireGauntlet");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}