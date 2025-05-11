using System;
using System.Collections.Generic;

namespace ProjectM
{
    public static class Logger
    {
        public static void LogInfo(string message) => Console.WriteLine("[INFO] " + message);
        public static void LogWarning(string message) => Console.WriteLine("[WARN] " + message);
        public static void LogError(string message) => Console.WriteLine("[ERROR] " + message);
    }

    public class Plugin
    {
        public static void Log(string message) => Console.WriteLine(message);
    }

    public class World
    {
        public static World __world = new World(); // Placeholder instance
        public static object ClientLocalUser = new object(); // Must be non-null
        public EntityManager EntityManager { get; set; } = new EntityManager();
    }
    public static class VWorld
    {
        public static Unity.Entities.World Server => Unity.Entities.World.DefaultGameObjectInjectionWorld;

        public static bool IsServer => true; // Set to true just to bypass client filtering
    }


    public class Inventory
    {
        // Extend this later if needed
    }

    public class CraftingStationServer
    {
        public static void OnUpdate() { }
    }

    public class RecipeData
    {
        public string Name { get; set; } = string.Empty;
        public PrefabGUID[] Requirements { get; set; } = Array.Empty<PrefabGUID>();
        public PrefabGUID OutputItem { get; set; } = new PrefabGUID(0);
        public int OutputAmount { get; set; } = 1;
        public float CraftTime { get; set; } = 10f;
        public PrefabGUID CraftingStation { get; set; } = new PrefabGUID(0);
    }

    public struct PrefabGUID
    {
        public int GuidHash;

        public PrefabGUID(int guidHash)
        {
            GuidHash = guidHash;
        }
    }

    public class EntityManager
    {
        public object CreateEntity()
        {
            return new object(); // Simulate an entity object
        }

        public DynamicBuffer<T> AddBuffer<T>(object entity)
        {
            return new DynamicBuffer<T>();
        }

        public void AddComponentData<T>(object entity, T data)
        {
            // Stub logic or simply do nothing
        }

    }

    public class DynamicBuffer<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }
    }



}
