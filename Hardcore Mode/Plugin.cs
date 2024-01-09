using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Hardcore_Mode.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardcore_Mode
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class ModBase : BaseUnityPlugin
    {
        private const string modGUID = "Athena.Hardcore_Mode";
        private const string modName = "Hardcore Mode";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static ModBase Instance;

        internal ManualLogSource mls;


        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("The Hardcore Mode Mod has Awoken.");

            harmony.PatchAll(typeof(ModBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }



    }



}
