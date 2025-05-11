using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using BepInEx.Logging;
using Bloodstone;
using Bloodstone.API;
using Bloodstone.Hooks;
using Unity.Entities;
using ProjectM;

namespace ForgottenWeapons
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        public static ManualLogSource Log { get; private set; }
        private Harmony _harmony;
        private static bool _injected = false;

        public override void Load()
        {
            Log = Logger.CreateLogSource(MyPluginInfo.PLUGIN_GUID);
            Log.LogInfo("🗡️ Forgotten Weapons plugin loaded!");

            // Server-side only
            if (!VWorld.IsServer)
            {
                Log.LogWarning("Client-side detected – disabling mod.");
                return;
            }

            _harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
            _harmony.PatchAll();

            InjectRecipeOnce();
        }

        public override bool Unload()
        {
            _harmony?.UnpatchSelf();
            return true;
        }

        private void InjectRecipeOnce()
        {
            if (_injected)
                return;

            _injected = true;
            Log.LogInfo("🔧 InjectRecipeOnce() called — recipe patch ready for logic.");
            // Add your recipe injection logic here
        }
    }
}
