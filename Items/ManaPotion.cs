using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RockosARPG;
using System.Collections.Generic;
using System.Linq;

namespace RockosMod.Items
{
	public class ManaPotion : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ManaPotion)
			{
				item.healMana = 0;
				item.consumable = false;
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.ManaPotion)
			{
				TooltipLine line = tooltips.FirstOrDefault();

				if (line != null)
					line.Text = "Restore 100 Mana";
			}
		}

		public override bool? UseItem(Item item, Player player)
		{
			if (item.type == ItemID.ManaPotion)
			{
				if (player.statMana < player.statManaMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.ManaEffect(100);
					Rockosplayer.manapotionregen = (int)(100f * Rockosplayer.skillPotPwr);
					Rockosplayer.manapotionregenpower = 1 * Rockosplayer.skillPotSpd;
					return true;
				}
			}
			return false;
		}
		public override bool ConsumeItem(Item item, Player player)
		{
			if (item.type == ItemID.ManaPotion)
			{
				if (player.statMana < player.statManaMax2)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					player.ManaEffect(100);
					Rockosplayer.manapotionregen = (int)(100f * Rockosplayer.skillPotPwr);
					Rockosplayer.manapotionregenpower = 1 * Rockosplayer.skillPotSpd;
					return true;
				}
			}
			return false;
		}
	}
}