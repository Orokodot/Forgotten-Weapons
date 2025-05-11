using BepInEx.Logging;
using HarmonyLib;
using ProjectM;
using Unity.Entities;

namespace ForgottenWeapons
{
    [HarmonyPatch(typeof(CraftingStationServer), nameof(CraftingStationServer.OnUpdate))]
    public static class CraftingStationPatch
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            // Use the correct World
            var world = Unity.Entities.World.DefaultGameObjectInjectionWorld;

            if (world == null)
            {
                Plugin.Log.LogWarning("World context not found.");
                return;
            }

            var entityManager = world.EntityManager;

            // Confirmation log
            Plugin.Log.LogInfo("Injecting Bone Reaper recipe into crafting stations...");

            // Custom crafting logic goes here
        }
    }
}
