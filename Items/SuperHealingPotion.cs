using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RockosARPG;
using System.Collections.Generic;
using System.Linq;

namespace RockosMod.Items
{
	public class SuperHealingPotion : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.SuperHealingPotion)
			{
				item.healLife = 0;
				item.consumable = false;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.SuperHealingPotion)
			{
				TooltipLine line = tooltips.FirstOrDefault();

				if (line != null)
					line.Text = "Restore 200 Health";
			}
		}

		public override bool? UseItem(Item item, Player player)
		{
			if (item.type == ItemID.SuperHealingPotion)
			{
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(200);
					Rockosplayer.lifepotionregen = (int)(200f * Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 2 * Rockosplayer.skillPotSpd;
					return true;
				}
			}
			return false;
		}

		public override bool ConsumeItem(Item item, Player player)
		{
			if (item.type == ItemID.SuperHealingPotion)
			{
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(200);
					Rockosplayer.lifepotionregen = (int)(200f * Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 2 * Rockosplayer.skillPotSpd;
					return true;
				}
			}
			return false;
		}
	}
}