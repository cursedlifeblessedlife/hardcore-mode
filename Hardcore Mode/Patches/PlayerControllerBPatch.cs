using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardcore_Mode.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPatch("SetPlayerSanityLevel")]
        [HarmonyPostfix]
        static void InfinitePatchUpdate(ref float ___healthRegenerateTimer, ref bool ___isPlayerAlone)
        {
            ___healthRegenerateTimer = 0.5f;
            ___isPlayerAlone = true;
        }

    }
}
