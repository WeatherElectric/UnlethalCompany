using System.Reflection;
using BepInEx;
using HarmonyLib;

namespace UnlethalCompany
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private readonly Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
        private void Awake()
        {
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded, version {PluginInfo.PLUGIN_VERSION}");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}