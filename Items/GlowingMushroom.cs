using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RockosARPG;
using System.Collections.Generic;
using System.Linq;

namespace RockosMod.Items
{
	public class GlowingMushroom : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.GlowingMushroom)
			{
				item.healLife = 0;
				item.consumable = false;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.GlowingMushroom)
			{
				TooltipLine line = tooltips.FirstOrDefault();

				if (line != null)
					line.Text = "Restore 25 Health";
			}
		}

		public override bool? UseItem(Item item, Player player)
		{
			if (item.type == ItemID.GlowingMushroom)
			{
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(25);
					Rockosplayer.lifepotionregen = (int)(25f * Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 1 * Rockosplayer.skillPotSpd;
					return true;
				}
			}
			return false;
		}
		public override bool ConsumeItem(Item item, Player player)
		{
			if (item.type == ItemID.GlowingMushroom)
			{
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(25);
					Rockosplayer.lifepotionregen = (int)(25f * Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 1 * Rockosplayer.skillPotSpd;
					return true;
				}
			}
			return false;
		}
	}
}