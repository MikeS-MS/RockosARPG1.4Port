using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RockosARPG;
using System.Collections.Generic;
using System.Linq;

namespace RockosMod.Items
{
	public class Mushroom : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Mushroom)
			{
				item.healLife = 0;
				item.consumable = false;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.Mushroom)
			{
				TooltipLine line = tooltips.FirstOrDefault();

				if (line != null)
					line.Text = "Restore 15 Health";
			}
		}

		public override bool? UseItem(Item item, Player player)
		{
			if (item.type == ItemID.Mushroom)
            {
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(15);
					Rockosplayer.lifepotionregen = (int)(15f*Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 1*Rockosplayer.skillPotSpd;
					return true;
				}
            }
			return false;
		}
		public override bool ConsumeItem(Item item, Player player)
		{
			if (item.type == ItemID.Mushroom)
			{
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(15);
					Rockosplayer.lifepotionregen = (int)(15f * Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 1 * Rockosplayer.skillPotSpd;
					return true;
				}
			}
			return false;
		}
	}
}