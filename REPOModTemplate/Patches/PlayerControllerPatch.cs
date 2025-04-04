using HarmonyLib;

namespace REPOModTemplate.Patches
{
    [HarmonyPatch(typeof(PlayerController))]
    public class PlayerControllerPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch("Start")]
        static void ModifyCrouchSpeed()
        {
            PlayerController.instance.CrouchSpeed = 3f;
        }
    }
}