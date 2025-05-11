# Forgotten Weapons

🗡️ *Restoring what was left behind...*

**Forgotten Weapons** is a mod for *V Rising* that reintroduces cut weapons (Bone Reaper, Copper Slasher, etc.) back into the game — fully craftable from existing workbenches using balanced recipes.

---

## 🛠️ Features

- Adds support for:
  - Bone Reaper / Slasher
  - Reinforced Bone Reaper / Slasher
  - Copper Reaper / Slasher
  - Merciless Copper Reaper / Slasher
- Fully integrated into the **Basic Crafting Bench**
- Server-side Harmony patching system
- Modular design for future weapon and item restores

---

## 💾 Installation

> ⚠️ Requires server modding tools like **BepInEx** and **Bloodstone**

1. Clone this repo into your V Rising server’s BepInEx `plugins` folder:
    ```bash
    git clone https://github.com/YOUR_USERNAME/ForgottenWeapons.git
    ```
2. Compile the project using your preferred C# IDE.
3. Load the server and verify recipe injection in logs.

---

## 🧱 Build Instructions

- Unity Modding Framework: [Bloodstone](https://github.com/Bloodstone-Project/Bloodstone)
- Patching Tool: [Harmony](https://github.com/pardeike/Harmony)
- Targets: `GameBootstrap`, `CraftingStationServer`, `GameFrame`

---

## 📌 To-Do

- [ ] Finalize `PrefabGUID`s for cut weapons
- [ ] Create balanced crafting recipes
- [ ] Add localization support
- [ ] Expand to armor or other cut content

---

## 🤝 Credits

- 💀 **Todokoro** — core developer & project reboot
- 🧪 **Mitch** — early testing and archive support
- 🔨 **Helskog** — foundational work from the original mod

---

## 📢 Want to Help?

Fork, PR, or reach out on Discord. Contributions and feedback are welcome.

