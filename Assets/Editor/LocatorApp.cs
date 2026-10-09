using UnityEditor;

// The Locator app: finds the room from wall-mounted AprilTags and a scanned room
// code, remembers it, and anchors Room/Content there. A template: copy the
// project and put your content under Content.
// Menu: Tools > Locator. Batchmode (re-runnable; Build also configures):
//   -buildTarget iOS -executeMethod LocatorApp.BuildIOS        (Xcode project in Builds/iOS)
//   -buildTarget Android -executeMethod LocatorApp.BuildQuest  (Builds/Quest/Locator.apk)
public static class LocatorApp
{
    public static readonly AprilTagsAppInfo App = new()
    {
        ProductName = "Locator",
        BundleId = "edu.utexas.tacc.locator",
        AppleTeamId = "MQSWMVW9A8",
        LogFileName = "locator.log",
        IPhoneScenes = new[] { "Assets/Scenes/iPhone Locator.unity" },
        QuestScenes = new[] { "Assets/Scenes/Quest Locator.unity" },
    };

    [MenuItem("Tools/Locator/Configure iOS")]
    public static void ConfigureIOS() => AprilTagsIOSSetup.Configure(App);

    [MenuItem("Tools/Locator/Build iOS Xcode Project")]
    public static void BuildIOS()
    {
        ConfigureIOS();
        AprilTagsIOSSetup.Build(App);
    }

    [MenuItem("Tools/Locator/Configure Quest")]
    public static void ConfigureQuest() => AprilTagsQuestSetup.Configure(App);

    [MenuItem("Tools/Locator/Build Quest APK")]
    public static void BuildQuest()
    {
        ConfigureQuest();
        AprilTagsQuestSetup.Build(App);
    }
}
