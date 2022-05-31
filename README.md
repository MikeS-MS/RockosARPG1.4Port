# RockosARPG Mod 1.4 Port
This is a mod that was ported by [MikeS](https://github.com/MikeS-MS) to 1.4 tModLoader (Original dev is Rockos, [original dev thread](https://forums.terraria.org/index.php?threads/rockos-arpg.41144/)).
I have not asked if they would allow this port, but they have given the source code inside the forum thread and they have not responded to a comment from 2022, so I don't even think asking them would provide an answer. 
Functionality may be broken, I've only fixed everything that was throwing errors and fixed the hooks/initializers that are deprecated.
This is by no means a working version of the mod, but a good chunk of the original features are ported.
If you'd like to completely make everything work, and/or extend the original features you can fork the repo and do it yourself.

If you'd like to download the working version of the mod here's a [link](github.com/MikeS-MS/RockosARPG1.4Port/releases/latest) to the releases.
- Click on Assets and download RockosARPG.tmod.
- To install it, go to Documents->MyGames->Terraria->tModLoader->Mods and paste the RockosARPG.tmod file there. (if any of these folders inside MyGames don't exist, create them yourself)

Click this [link](github.com/MikeS-MS/RockosARPG1.4Port/releases/latest), open up Assets and download RockosARPG_Source.zip if you'd like to get the source code.

Bugs I've noticed:
In Player.cs (26k lines sheeesh):
- There's a CreatePlayer method, which I think was the method called when ModPlayer was Initialized - basically current day void Initialize() - on the tmodloader version way back when the mod was last updated.

- There's a bug when player attacks with any weapon (not tools) there's an insane amount of healing, which is not intended imo, neither is there any damage done by them to enemies. I'm suspecting it might be because the original developer changed a lot of the terraria behaviour from the ground-up instead of using hooks to modify behaviour.

- There's a bug with how the stats are displayed and most likely the values are weird by themselves as I don't exactly understand how the new ones work. Look into how the dev used player.classNameCrit and player.classNameDamage (for example player.meleeCrit and player.meleeDamage)

General Bugs:
- Something doesn't unload properly, probably because the mod modifies values directly, and that makes it so the game crashes when reloading (only happenned when both this mod and modderstoolkit, and hero's mod are on).

My advice:
If you'd like to make it work, I think you should remake the entire thing ground up while looking at what the mod developer intended in the original mod. There's an insane amount of unnecessary code.
