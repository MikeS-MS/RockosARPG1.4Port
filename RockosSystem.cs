using Terraria.ModLoader;

namespace RockosARPG
{
    public class RockosSystem : ModSystem
    {
        public static ModKeybind QuickHealhKeybind { get; private set; }
        public static ModKeybind QuickManaKeybind { get; private set; }
        public static ModKeybind FullMenuKeybind { get; private set; }

        public override void Load()
        {
            QuickHealhKeybind = KeybindLoader.RegisterKeybind(Mod, "QuickHeal", "H");
            QuickManaKeybind = KeybindLoader.RegisterKeybind(Mod, "QuickMana", "J");
            FullMenuKeybind = KeybindLoader.RegisterKeybind(Mod, "Full Menu", "Escape");
        }

        public override void Unload()
        {
            QuickHealhKeybind = null;
            QuickManaKeybind = null;
            FullMenuKeybind = null;
        }
    }
}
