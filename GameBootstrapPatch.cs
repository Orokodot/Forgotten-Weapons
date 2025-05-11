using HarmonyLib;
using ProjectM;
using Unity.Entities;

namespace ForgottenWeapons
{
    [HarmonyPatch(typeof(GameBootstrap), nameof(GameBootstrap.InitializeSystems))]
    public static class GameBootstrapPatch
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            Plugin.Log.LogInfo("GameBootstrap initialized. Injecting Bone Reaper recipe...");

            var world = Unity.Entities.World.DefaultGameObjectInjectionWorld;

            if (world == null)
            {
                Plugin.Log.LogWarning("World context not found during GameBootstrap.");
                return;
            }

            // Safely get access to the EntityManager
            var entityManager = world.EntityManager;

            // Inject your recipe logic
            Plugin.InjectRecipeOnce(entityManager);
        }
    }
}
