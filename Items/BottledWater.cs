using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RockosARPG;
using System.Collections.Generic;
using System.Linq;

namespace RockosMod.Items
{
	public class BottledWater : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BottledWater)
			{
				item.healLife = 0;
				item.consumable = false;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.BottledWater)
			{
				TooltipLine line = tooltips.FirstOrDefault();

				if (line != null)
					line.Text = "Restore 20 Health";
			}
		}

		public override bool? UseItem(Item item, Player player)
		{
			if (item.type == ItemID.BottledWater)
			{
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(20);
					Rockosplayer.lifepotionregen = (int)(20f * Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 1 * Rockosplayer.skillPotSpd;
					return true;
				}
			} 
			return false;
		}
		public override bool ConsumeItem(Item item, Player player)
		{
			if (item.type == ItemID.BottledWater)
			{
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(20);
					Rockosplayer.lifepotionregen = (int)(20f * Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 1 * Rockosplayer.skillPotSpd;
					return true;
				}
			}
			return false;
		}
	}
}