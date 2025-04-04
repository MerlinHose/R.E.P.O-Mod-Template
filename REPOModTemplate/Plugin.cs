using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using REPOModTemplate.Patches;

namespace REPOModTemplate
{
    [BepInPlugin(Guid, Name, Version)]
    public class RepoModClass : BaseUnityPlugin
    {
        private const string Guid = "com.yourname.repomodtemplate";
        private const string Name = "REPO Mod Template";
        private const string Version = "1.0.0";
        
        private readonly Harmony _harmony = new Harmony(Guid);
        
        private static RepoModClass _instance;
        private ManualLogSource _logger;

        private void Awake()
        {
            _logger = BepInEx.Logging.Logger.CreateLogSource(Guid);
            
            if (_instance == null)
            {
                _instance = this;
                _harmony.PatchAll(typeof(RepoModClass));
                _harmony.PatchAll(typeof(PlayerControllerPatch));
                
                _logger.LogInfo($"Plugin {Name} is loaded!");
            }
            else
            {
                _logger.LogWarning($"Plugin {Name} is already loaded!");
            }
        }
    }
}