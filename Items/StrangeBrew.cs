using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RockosARPG;
using System.Collections.Generic;
using System.Linq;

namespace RockosMod.Items
{
	public class StrangeBrew : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.StrangeBrew)
			{
				item.healMana = 0;
				item.consumable = false;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.StrangeBrew)
			{
				TooltipLine line = tooltips.FirstOrDefault();
				TooltipLine line2 = tooltips[1];

				if (line != null)
					line.Text = "Restore 80 Health";

				if (line2 != null)
					line2.Text = "Restore 400 Mana";
			}
		}

		public override bool? UseItem(Item item, Player player)
		{
			if (item.type == ItemID.StrangeBrew)
			{
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(80);
					Rockosplayer.lifepotionregen = (int)(80f * Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 1 * Rockosplayer.skillPotSpd;
					return true;
				}

				if (player.statMana < player.statManaMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.ManaEffect(400);
					Rockosplayer.manapotionregen = (int)(400f * Rockosplayer.skillPotPwr);
					Rockosplayer.manapotionregenpower = 2 * Rockosplayer.skillPotSpd;
					return true;
				}
			} 
			return false;
		}
		public override bool ConsumeItem(Item item, Player player)
		{
			if (item.type == ItemID.StrangeBrew)
			{
				if (player.statLife < player.statLifeMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.HealEffect(80);
					Rockosplayer.lifepotionregen = (int)(80f * Rockosplayer.skillPotPwr);
					Rockosplayer.lifepotionregenpower = 1 * Rockosplayer.skillPotSpd;
					return true;
				}

				if (player.statMana < player.statManaMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.ManaEffect(400);
					Rockosplayer.manapotionregen = (int)(400f * Rockosplayer.skillPotPwr);
					Rockosplayer.manapotionregenpower = 2 * Rockosplayer.skillPotSpd;
					return true;
				}
			}
			return false;
		}
	}
}