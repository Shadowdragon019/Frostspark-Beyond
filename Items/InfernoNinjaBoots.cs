using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace FrostsparkBeyond.Items
{
	[AutoloadEquip(EquipType.Shoes)]
	public class InfernoNinjaBoots : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Allows flight, immensely fast running, provides the ability to walk on water along with lava, extra mobility on ice, and negates fall damage\nAllows the ability to climb walls and dash\n15% increased movement speed\n20% increased melee damage and speed\n20% increased critical strike chance\nIncreases armor penetration by 10\nGives a chance to dodge attacks\nAttackers take damage\nIncreases melee knockback and inflicts fire damage on attack\nGrants immunity to fire blocks, chill and freezing effects, and 14 seconds of immunity to lava");
		}

		public override void SetDefaults() 
		{
            item.accessory = true;
            item.value = 1;
            item.width = 38;
            item.height = 32;
            item.rare = ItemRarityID.Yellow;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
        {
          	//Hallowed Boots
				player.accRunSpeed = 10f;
				player.rocketBoots = 3;
				player.moveSpeed += 0.15f;
				player.iceSkate = true;
        		player.noFallDmg = true;
        	//Inferno Ninja Gear
        		player.blackBelt = true;
				player.dash = 1;
				player.spikedBoots = 2;
        		player.kbGlove = true;
				player.meleeSpeed += 0.2f;
				player.meleeDamage += 0.2f;
				player.magmaStone = true;
				player.thorns = 2f;
        		player.armorPenetration += 10;
            //Living Magnifying Glass
		        player.meleeCrit += 20;
				player.rangedCrit += 20;
				player.magicCrit += 20;
				player.thrownCrit += 20;
			//Lava Waders
				player.waterWalk = true;
				player.fireWalk = true;
				player.lavaMax += 840;
			//Other
				player.buffImmune[46] = true;
				player.buffImmune[47] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "HallowedBoots");
            recipe.AddIngredient(mod, "InfernoNinjaGear");
			recipe.AddIngredient(ItemID.LavaWaders, 1);
            recipe.AddIngredient(mod, "LivingMagnifyingGlass");
			recipe.AddTile(TileID.TinkerersWorkbench); 
            recipe.SetResult(this); 
            recipe.AddRecipe(); 
        } 
	} 
} 