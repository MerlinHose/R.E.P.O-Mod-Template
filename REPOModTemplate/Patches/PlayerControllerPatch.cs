using HarmonyLib;

namespace REPOModTemplate.Patches
{
    [HarmonyPatch(typeof(PlayerController))]
    public class PlayerControllerPatch
    {
        [HarmonyPatch("CrouchSpeed")]
        [HarmonyPrefix]
        static void CrouchSpeedPatch(ref float result)
        {
            result = 3f;
        }
    }
}