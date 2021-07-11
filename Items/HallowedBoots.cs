using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace FrostsparkBeyond.Items
{
[AutoloadEquip(EquipType.Shoes)]
	public class HallowedBoots : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("'Has the same movement speed as the Frostspark Boots, the tooltip is wrong'\nAllows flight, seriously fast running, extra mobility on ice, and negates fall damage\n8% increased movement speed");
		}

		public override void SetDefaults() 
		{
            item.accessory = true;
            item.value = 850000;
            item.width = 28;
            item.height = 28;
            item.rare = ItemRarityID.Lime;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
        {
				player.accRunSpeed = 8f;
				player.rocketBoots = 3;
				player.moveSpeed += 0.08f;
				player.iceSkate = true;
        player.noFallDmg = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrostsparkBoots, 1);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}