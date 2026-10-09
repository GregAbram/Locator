# Locator

A starter app for shared AR on **Quest 3** and **iPhone**: it finds the room from
wall-mounted AprilTags (tagStandard41h12) and puts `Room/Content` in the same
place for every viewer. Copy this project and put your content under
`Room/Content`, in room coordinates. [PVAR](https://github.com/GregAbram/PVAR)
is built this way.

Unity 6000.3.10f1 (Mixed Reality template), with
[edu.tacc.apriltags](https://github.com/GregAbram/AprilTags) for localization.

## Using it

1. Survey the room once with the [Survey](https://github.com/GregAbram/Survey)
   app and print its room code (QR).
2. Start Locator. With no room yet it scans for a room code by itself; look at
   the printed code from about 40-70 cm. It remembers the room from then on.
3. Look at two of the room's tags. The tag markers turn red and the magenta
   reference post appears once the room is anchored; every device should see
   the post in the same spot.

Controls: **Quest**: A scan now, B re-anchor, X forget learned tags, left
trigger scan a room code. **iPhone**: the on-screen buttons.

## Building

- Menu **Tools > Locator**: Configure iOS / Build iOS Xcode Project,
  Configure Quest / Build Quest APK.
- Batchmode: `-buildTarget iOS -executeMethod LocatorApp.BuildIOS` (Xcode
  project in `Builds/iOS`), `-buildTarget Android -executeMethod
  LocatorApp.BuildQuest` (`Builds/Quest/Locator.apk`).
- Android Build Support must be installed in every editor, Mac included (the
  Meta SDK's editor code needs it).
- The app is declared in `Assets/Editor/LocatorApp.cs` (name, bundle ID,
  scenes). The setup creates a scene only when it's missing, so edit the
  scenes freely. To start a new app from this one, change the name, bundle ID
  and scene paths there.
