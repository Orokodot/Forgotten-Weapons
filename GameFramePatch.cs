using Bloodstone.Hooks;
using HarmonyLib;
using Unity.Entities;

namespace ForgottenWeapons
{
    [HarmonyPatch(typeof(GameFrame), nameof(GameFrame.OnUpdate))]
    public static class GameFramePatch
    {
        private static bool injected = false;

        [HarmonyPostfix]
        public static void Postfix()
        {
            if (injected) return;

            var world = World.DefaultGameObjectInjectionWorld;
            if (world == null)
            {
                Plugin.Log.LogWarning("World not available yet.");
                return;
            }

            var entityManager = world.EntityManager;
            if (!entityManager.World.IsCreated)
            {
                Plugin.Log.LogWarning("EntityManager not initialized.");
                return;
            }

            // ✅ Only inject once
            injected = true;

            Plugin.Log.LogInfo("GameFrame hook triggered. Injecting Bone Reaper...");

            // 🔧 Insert your recipe injection logic here
        }
    }
}
