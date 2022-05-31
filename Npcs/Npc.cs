using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RockosARPG
{
	public class RockosGlobalNPC : GlobalNPC
	{
		public static int wholasthit = 800;

		
		
		//Npc exp table
		public static int[] negnpcexp = new int[]
		{
		
			0,
			3,
			0,
			4,
			100,
			5,
			14,
			9,
			10,
			12,
			22,
			11,
			24,
			26,
			32,
			27,
			33,
			39
		
		};
		
		public static int[] npcexp = new int[]
		{
			0,
			5,
			12,
			7,
			350,
			0,
			21,
			50,
			0,
			0,
			18,
			0,
			0,
			13,
			0,
			0,
			15,
			0,
			0,
			0,
			0,
			20,
			0,
			21,
			37,
			0,
			31,
			33,
			35,
			32,
			0,
			34,
			33,
			0,
			36,
			500,
			0,
			0,
			0,
			90,
			0,
			0,
			35,
			82,
			22,
			115,
			1,
			51,
			47,
			6,
			200,
			14,
			150,
			125,
			0,
			1,
			37,
			41,
			19,
			30,
			35,
			17,
			48,
			8,
			28,
			53,
			50,
			22,
			0,
			29,
			40,
			40,
			40,
			30,
			1,
			93,
			0,
			175,
			108,
			147,
			152,
			88,
			104,
			155,
			165,
			500,
			133,
			800,
			0,
			0,
			0,
			0,
			0,
			95,
			162,
			111,
			0,
			0,
			220,
			0,
			0,
			190,
			134,
			117,
			235,
			0,
			0,
			0,
			0,
			350,
			156,
			34,
			0,
			650,
			0,
			0,
			0,
			150,
			0,
			0,
			189,
			129,
			166,
			0,
			0,
			2000,
			1800,
			2400,
			0,
			0,
			0,
			0,
			7,
			126,
			4000,
			0,
			0,
			197,
			140,
			0,
			144,
			112,
			0,
			200,
			200,
			200
			
		
		};
		
		
		
		public override void ModifyHitByItem(NPC npc, Player P, Item item, ref int damage, ref float knockback, ref bool crit)
		{
			RockosPlayer Rockosplayer = P.GetModPlayer<RockosPlayer>();
			if(P.whoAmI == Main.myPlayer)Rockosplayer.npcgothurttimeleft=120;
			if(P.whoAmI == Main.myPlayer)Rockosplayer.npcwhogothurt=npc.whoAmI;
			if(P.whoAmI == Main.myPlayer)wholasthit=Main.myPlayer;
			
			
			if(crit && Rockosplayer.skillCritMult > 1) damage = (int)(damage*Rockosplayer.skillCritMult);
			if(Rockosplayer.skillLifeLeech > 0 || Rockosplayer.skillNonRangeLifeLeech > 0)
			{
				Rockosplayer.lifeleechtotal += (float)((float)damage * Rockosplayer.skillLifeLeech);
				if(!(P.inventory[P.selectedItem].DamageType == DamageClass.Ranged)) Rockosplayer.lifeleechtotal += (float)((float)damage * Rockosplayer.skillNonRangeLifeLeech);
			}
			if(Rockosplayer.skillManaLeech > 0 || Rockosplayer.skillNonRangeManaLeech > 0)
			{
				Rockosplayer.manaleechtotal += (float)((float)damage * Rockosplayer.skillManaLeech);
				if(!(P.inventory[P.selectedItem].DamageType == DamageClass.Ranged)) Rockosplayer.manaleechtotal += (float)((float)damage * Rockosplayer.skillNonRangeManaLeech);
			}
			
			//Main.NewText("Melee");
		}
		
		public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			Player P = Main.player[projectile.owner];
			RockosPlayer Rockosplayer = P.GetModPlayer<RockosPlayer>();
			if(P.whoAmI == Main.myPlayer)Rockosplayer.npcgothurttimeleft=120;
			if(P.whoAmI == Main.myPlayer)Rockosplayer.npcwhogothurt=npc.whoAmI;
			if(P.whoAmI == Main.myPlayer)wholasthit=Main.myPlayer;
			
			
			if(crit && Rockosplayer.skillCritMult > 1) damage = (int)(damage*Rockosplayer.skillCritMult);
			if(Rockosplayer.skillLifeLeech > 0 || Rockosplayer.skillNonRangeLifeLeech > 0)
			{
				Rockosplayer.lifeleechtotal += (float)((float)damage * Rockosplayer.skillLifeLeech);
				if(!(P.inventory[P.selectedItem].DamageType == DamageClass.Ranged)) Rockosplayer.lifeleechtotal += (float)((float)damage * Rockosplayer.skillNonRangeLifeLeech);
			}
			if(Rockosplayer.skillManaLeech > 0 || Rockosplayer.skillNonRangeManaLeech > 0)
			{
				Rockosplayer.manaleechtotal += (float)((float)damage * Rockosplayer.skillManaLeech);
				if(!(P.inventory[P.selectedItem].DamageType == DamageClass.Ranged)) Rockosplayer.manaleechtotal += (float)((float)damage * Rockosplayer.skillNonRangeManaLeech);
			}
			//Main.NewText("proj");
		}
		
		/*public override bool StrikeNPC(NPC npc, ref double damage, int defense, ref float knockback, int hitDirection, ref bool crit)
		{

			RockosPlayer Rockosplayer = (RockosPlayer)Main.myPlayer.GetModPlayer(mod, "RockosPlayer");
			if(crit && Rockosplayer.skillCritMult > 1) damage = (damage*Rockosplayer.skillCritMult);
			Main.NewText("strike");
			return true;
		}*/

		/*public override bool PreNPCLoot(NPC npc)
		{
			Main.NewText("active");
			return true;
		}*/
		
		
		public override bool CheckDead(NPC npc)
		{
		//RockosPlayer Rockosplayer1 = (RockosPlayer)Main.player[Main.myPlayer].GetModPlayer(mod, "RockosPlayer");	
		int expgained=0;
		
			// TODO: Might not be typename.
			if(!npc.friendly)
			{
				if(npc.TypeName == "Slimeling" || npc.TypeName == "Slimer2" || npc.TypeName == "Green Slime" || npc.TypeName == "Pinky" || npc.TypeName == "Baby Slime" || npc.TypeName == "Black Slime" || npc.TypeName == "Purple Slime" || npc.TypeName == "Red Slime" || npc.TypeName == "Yellow Slime" || npc.TypeName == "Jungle Slime" || npc.TypeName == "Little Eater" || npc.TypeName == "Big Eater" || npc.TypeName == "Short Bones" || npc.TypeName == "Big Boned" || npc.TypeName == "Heavy Skeleton" || npc.TypeName == "Little Stinger" || npc.TypeName == "Big Stinger")	
				{
					//drop explosive arrow
					//if(Main.rand.Next(5)==0) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, "Explosive Arrow", Main.rand.Next(2,3), false, 0);
					
					//Drop Exp orb
					//Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, "Exp Orb", 1, false, 0);
					
					int type1 = 0;
					if(npc.TypeName == "Slimeling")type1=1;
					if(npc.TypeName == "Slimer2")type1=2;
					if(npc.TypeName == "Green Slime")type1=3;
					if(npc.TypeName == "Pinky")type1=4;
					if(npc.TypeName == "Baby Slime")type1=5;
					if(npc.TypeName == "Black Slime")type1=6;
					if(npc.TypeName == "Purple Slime")type1=7;
					if(npc.TypeName == "Red Slime")type1=8;
					if(npc.TypeName == "Yellow Slime")type1=9;
					if(npc.TypeName == "Jungle Slime")type1=10;
					if(npc.TypeName == "Little Eater")type1=11;
					if(npc.TypeName == "Big Eater")type1=12;
					if(npc.TypeName == "Short Bones")type1=13;
					if(npc.TypeName == "Big Boned")type1=14;
					if(npc.TypeName == "Heavy Skeleton")type1=15;
					if(npc.TypeName == "Little Stinger")type1=16;
					if(npc.TypeName == "Big Stinger")type1=17;
					
					
					//Overkill Bonus exp
					if(npc.life < 0-(npc.lifeMax*20/100))
					{
						CombatText.NewText(new Rectangle((int)npc.position.X, (int)npc.position.Y-70, 10, 10), new Color(255, 80, 80, 255), "OVERKILL", false);	
						//expgained=(int)(Rockosplayer1.negnpcexp[type1]*10/100);
						expgained=(int)(negnpcexp[type1]*10/100);
					}
					//expgained+=Rockosplayer1.negnpcexp[type1];
					expgained+=negnpcexp[type1];
					if(expgained==0 && npc.type != 412 && npc.type != 413)expgained=(int)((float)npc.lifeMax*20f/100f*(1+((float)npc.defense/3f)));
					foreach(Player Pl in Main.player)
					{
					
						if(Pl.active && !Pl.dead)
						{
							RockosPlayer Rockosplayer = Pl.GetModPlayer<RockosPlayer>();
							string textxpgain = "";
							textxpgain = expgained+ " EXP";
							if(expgained < 0) expgained = Math.Abs(expgained);
							if(Pl.active && !Pl.dead && Pl.whoAmI==Main.myPlayer && Vector2.Distance(Pl.position,npc.position)<1000)Rockosplayer.exp += expgained;
							//CombatText.NewText(new Rectangle((int)Pl.position.X, (int)Pl.position.Y-30, 50, 50), new Color(100, 100, 255, 255), expgained + " EXP", false);
							if(Pl.active && !Pl.dead && Vector2.Distance(Pl.position,npc.position)<1000)CombatText.NewText(new Rectangle((int)Pl.position.X, (int)Pl.position.Y-50, 50, 50), new Color(100, 100, 255, 255), textxpgain, false);	
						
						}
					
					}
					
				}
				else
				{

					//Drop Region ........................
					
					//Drop meteor By the skeleton prime
					//if(npc.type==127 && Main.rand.Next(5)==0)Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, "Meteor", 1, false, 0);
					
					//Drop Ultima By the twin Eye
					//if(npc.type==125 && Main.rand.Next(5)==0 || npc.type==126 && Main.rand.Next(5)==0 )Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, "Ultima", 1, false, 0);
					
					//Drop Explosive arrow By every npc arround
					//if(Main.rand.Next(5)==0 && Main.hardMode) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, "Explosive Arrow", Main.rand.Next(2,3), false, 0);
					
					//Drop Exp Orb
					//Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, "Exp Orb", 1, false, 0);
					
					//Overkill Bonus exp
					if(npc.life < 0-(npc.lifeMax*20/100) && npc.type<=145)
					{
						CombatText.NewText(new Rectangle((int)npc.position.X, (int)npc.position.Y-70, 10, 10), new Color(255, 80, 80, 255), "OVERKILL", false);	
						//expgained=(int)(Rockosplayer1.npcexp[npc.type]*10/100);
						expgained=(int)(npcexp[npc.type]*10/100);
					}
					else if(npc.life < 0-(npc.lifeMax*20/100))
					{
					CombatText.NewText(new Rectangle((int)npc.position.X, (int)npc.position.Y-70, 10, 10), new Color(255, 80, 80, 255), "OVERKILL", false);	
					expgained=(int)((float)npc.lifeMax*20f/100f*(1+((float)npc.defense/3f)));
					expgained+=(int)((float)expgained*10f/100f);
					}
					//if(npc.type<=145)expgained+=Rockosplayer1.npcexp[npc.type];
					if(npc.type<=145)expgained+=npcexp[npc.type];
					if(expgained==0 && npc.type != 412 && npc.type != 413)expgained=(int)((float)npc.lifeMax*20f/100f*(1+((float)npc.defense/3f)));
					foreach(Player Pl in Main.player)
					{
						if(Pl.active && !Pl.dead)
						{
							RockosPlayer Rockosplayer = Pl.GetModPlayer<RockosPlayer>();
							string textxpgain = "";
							textxpgain = expgained+ " EXP";
							if(expgained < 0) expgained = Math.Abs(expgained);
							//CombatText.NewText(new Rectangle((int)Pl.position.X, (int)Pl.position.Y-30, 50, 50), new Color(100, 100, 255, 255), expgained + " EXP", false);
							if(Pl.active && !Pl.dead && Pl.whoAmI==Main.myPlayer && Vector2.Distance(Pl.position,npc.position)<1000)Rockosplayer.exp += expgained;
							if(Pl.active && !Pl.dead && Vector2.Distance(Pl.position,npc.position)<1000)CombatText.NewText(new Rectangle((int)Pl.position.X, (int)Pl.position.Y-50, 50, 50), new Color(100, 100, 255, 255), textxpgain, false);
							
						}		
					}	
				}
				
			}
			
			return true;
			
			
		}


		//public override void NPCLoot(NPC npc) 
		//{
			//if(Main.dedServ) return;
			//NetMessage.SendData(25, -1, -1, "Type: "+npc.type, 255, 225f, 25f, 25f, 0);	
		//}







		/*public void PostDraw(SpriteBatch SP)
		{
			if(!Rockosplayer.hpbarabove)return;
			if (npc.life>0 && npc.life != npc.lifeMax)
			{
				Texture2D TEX = Main.goreTexture[Config.goreID["ENNEMY_BAR"]];
				
				//HP bar region
				Color Exper = Color.White;
				Exper.A = 180;
				Color Experi = Color.White;
				Experi.A = 180;

				int TX = TEX.Width;
				int TY = TEX.Height;

				int MX = 10;
				//int MY = 10;

				//int AX = 14;
				//int AY = 14;
				
				float X = npc.position.X + npc.width/2 + 12 - Main.player[Main.myPlayer].position.X + Main.screenWidth/2;
				float Y = npc.position.Y - npc.height - 30 - Main.player[Main.myPlayer].position.Y + Main.screenHeight/2;

				float OX = X;
				float OY = Y;

				float TiS = Main.inventoryScale;
				Main.inventoryScale = 1f;

				#region draw mid part

				for(float i = 25; i > 0; i-= 0.5f)
				{
					Experi = Color.Red;
					X-=1f*Main.inventoryScale;
					int XC = MX;
					if(((float)npc.life/(float)npc.lifeMax)*25 < i) XC+=2;
					Experi.A = 180;
					SP.Draw(
					TEX,
					new Vector2(X,Y+8),
					new Rectangle?(new Rectangle(XC, 8, 1, 8)),
					Experi,
					0f,
					default(Vector2),
					Main.inventoryScale,
					SpriteEffects.None,
					0f);
				}

				#endregion

				Main.inventoryScale = TiS;
			
			}
		}*/
		
	}
}