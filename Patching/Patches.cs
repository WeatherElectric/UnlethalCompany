using HarmonyLib;
using UnityEngine;
// ReSharper disable InconsistentNaming, it's harmony, HAS to be __instance

namespace UnlethalCompany.Patching;

public static class Patches
{
    [HarmonyPatch(typeof(EnemyAI))]
    internal class EnemyPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(EnemyAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(Turret))]
    internal class TurretPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(Turret __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(Landmine))]
    internal class LandminePatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(Landmine __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
}