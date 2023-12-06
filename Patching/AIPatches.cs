using HarmonyLib;
using UnityEngine;
// ReSharper disable InconsistentNaming, it's harmony, HAS to be __instance

namespace UnlethalCompany.Patching;

public static class AIPatches
{
    [HarmonyPatch(typeof(FlowermanAI))]
    internal class FlowermanPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(FlowermanAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(HoarderBugAI))]
    internal class HoarderBugPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(HoarderBugAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(SpringManAI))]
    internal class SpringManPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(SpringManAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(CrawlerAI))]
    internal class CrawlerPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(CrawlerAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(SandSpiderAI))]
    internal class SandSpiderPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(SandSpiderAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(JesterAI))]
    internal class JesterPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(JesterAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(CentipedeAI))]
    internal class CentipedePatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(CentipedeAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(BlobAI))]
    internal class BlobPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(BlobAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(DressGirlAI))]
    internal class DressGirlPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(DressGirlAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(PufferAI))]
    internal class PufferPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(PufferAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(MouthDogAI))]
    internal class MouthDogPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(MouthDogAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(ForestGiantAI))]
    internal class ForestGiantPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(ForestGiantAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(SandWormAI))]
    internal class SandWormPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(SandWormAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
    
    [HarmonyPatch(typeof(BaboonBirdAI))]
    internal class BaboonBirdPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Delete(BaboonBirdAI __instance)
        {
            Object.Destroy(__instance.gameObject);
        }
    }
}