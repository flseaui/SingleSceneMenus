/** This class is Auto-Generated **/

using UnityEditor;

namespace Editor.Generated
{
    public static class GMenuSwapMenuItems {

    [MenuItem("Menu/MainMenu")]
    private static void SwapToMainMenu() => MenuSwap.SwapMenu("MainMenu");
    [MenuItem("Menu/MainMenu", true)]
    private static bool SwapToMainMenuValidation() => MenuSwap.SwapMenuValidation("MainMenu");

    [MenuItem("Menu/OtherMenu")]
    private static void SwapToOtherMenu() => MenuSwap.SwapMenu("OtherMenu");
    [MenuItem("Menu/OtherMenu", true)]
    private static bool SwapToOtherMenuValidation() => MenuSwap.SwapMenuValidation("OtherMenu");


    }
}
