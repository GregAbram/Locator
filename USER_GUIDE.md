# Locator: user guide

Locator puts everyone's AR in the same place. Each device finds the room from
the AprilTags on its walls and places the room's content there, so people using
different devices see the same thing in the same spot. It runs on **Meta Quest
3** and **iPhone**, and the two can be mixed in the same room.

Locator is also a **starting point for other apps**. PVAR, for example, is
Locator plus ParaView data. Everything in this guide applies to those apps as
well.

---

## 1. Before you start

The room has to be set up once with the **Survey** app (see the Survey user
guide). Survey produces a **room code**: a printed QR code that holds the
room's name, the tag size and where each tag is.

- **One tag is required. More are optional, and they help.**
  - **One tag:** each device must get within **1.2 m** of it to anchor. The
    room's direction comes from that single tag's orientation, which varies by
    1-3° between devices and viewpoints, so devices can disagree by several
    centimeters (a 1° difference is 5 cm at 3 m).
  - **Two or more tags:** a device anchors by fitting the room to the
    positions of **any two** tags it has seen, which is far more consistent
    between devices. It works from farther away, and it keeps the room in
    place as you move around.

You need:
- the tags on the walls where they were when the room was surveyed;
- the room code, printed (or on another phone's screen);
- the **Locator** app on each device.

## 2. First time in a room: scan the room code

1. **Open Locator.** **Quest:** **Library → Unknown sources → Locator**, and
   allow the **headset camera** the first time. **iPhone:** open **Locator**,
   allow the **camera** and hold the phone in landscape.
2. A device with no room yet starts looking for a room code by itself. The
   status says:
   ```
   No room yet: point the camera at the room's QR code
   ```
3. **Look at the room code from about 40-70 cm** and hold steady for a moment.
   The iPhone refocuses for the code; on the Quest, move a little closer or
   farther if it doesn't read within a few seconds.
4. When it reads, the status shows the room:
   ```
   Room: TACC (survey H48CSS)
   ```
   **The device remembers this room**, so you won't need the code again until
   the room changes. The **survey ID** (H48CSS) is the same on every device using
   this survey: if two devices show different IDs, they're on different
   surveys, and one needs to scan the current code.

## 3. Anchor the room

Once it has a room, Locator looks for the room's tags on its own all the time.
You don't press anything; just look at the tags.

- **With two or more tags:** look at one tag, then another. Each can be at any
  comfortable distance, and the two don't need to be in view at the same time.
  Status before the second tag:
  ```
  Room: provisional - get a second tag in view
  ```
- **With one tag:** get within **1.2 m** of it and look at it steadily for a
  few seconds:
  ```
  Room: provisional - get within 1.2 m of tag 8 (5/8 close sightings)
  ```

When the room is anchored:
- the **status** says `Room: anchored, fit from 2 tags, RMS 0.8 cm`. The RMS is
  how well the tags agree with the survey: under about 2 cm is good;
- the **tag markers** (small cubes on the tags) turn **red**. While the room is
  still provisional they're **yellow**;
- a **magenta reference post** appears (see below);
- on Quest, the controllers **buzz**;
- the app's content appears. Content stays hidden until the room is anchored,
  so it never shows up in the wrong place first.

**Move slowly while anchoring.** Frames taken while the camera turns faster
than about 8°/s are dropped.

## 4. Checking that devices agree

The room's origin is the **center of the first tag surveyed**: height 0 is
that tag's center, not the floor, and content is placed relative to it.

The **magenta reference post** (a thin post with a cross bar) marks one fixed
room position: below the middle of the surveyed tags, starting at the first
tag's height. It's the same position on every device.
To check two devices, have both people look at the post and compare where each
sees it, or point at it. They should match to within a few centimeters. If
they don't:

1. Make sure both show the **same survey ID**.
2. **Re-anchor** on the device that's off (Quest **B**, iPhone **Re-anchor**)
   and look at two tags again.
3. With a one-tag room, anchor from closer and more straight on. Better still,
   add a second tag and re-survey.

## 5. Moving around

- Locator keeps watching the tags in the background, more slowly once
  anchored, and **corrects for tracking drift** whenever it sees a tag.
- If tracking jumps (after you cover the cameras, or when the device loses
  tracking and recovers), the next tags it sees disagree with the room. After
  a few disagreeing sightings, it **re-anchors by itself**.
- **Tags that weren't surveyed** (added later, at the same printed size) are
  **learned** once the room is anchored: they get **green** markers after
  about 20 sightings and then help hold the room in place. They're saved on
  that device only. A tag that keeps disagreeing (because it was moved, say)
  is dropped.

## 6. Changing rooms, or a new survey

- **Scan room code** (Quest **left trigger**, iPhone **Scan room code**), then
  look at the new code. A different survey replaces the room and anchoring
  starts over. Scanning the code of the room you're already in changes
  nothing. Scanning again also picks up a **renamed** room.
- **Cancel** with the same button.

## 7. Controls

| Action | Quest | iPhone |
|---|---|---|
| Scan at full speed now | **A** | **Scan now** |
| Re-anchor (forget this session's sightings) | **B** | **Re-anchor** |
| Forget learned tags | **X** | **Forget learned** |
| Scan a room code / cancel | **Left trigger** | **Scan room code** / **Cancel scan** |

The status panel on Quest floats in front of you and follows your head. On
iPhone it's below the buttons. It lists every tag seen, with its state and
distance:

```
Room: TACC (survey H48CSS)
Room: anchored, fit from 3 tags, RMS 0.9 cm   scan every 3.0s
  tag 3: measured, 2.1 m away
  tag 7: measured, last seen 12s ago
  tag 8: measured, 1.4 m away
```

## 8. Troubleshooting

| Problem | What to do |
|---|---|
| "No room yet" and the code won't read | Get to 40-70 cm, square on, with good light and no glare. Print the code at least 8 cm across. |
| A tag is never seen | Get closer and face it, with good light. Only the room's tags at the surveyed size count. |
| Stuck on "get a second tag in view" | The room has two or more surveyed tags; look at a second one. |
| Stuck on "get within 1.2 m" | One-tag room: move closer to the tag. |
| RMS above about 3 cm | A tag may have moved since the survey. Re-survey, or take that tag down. |
| Room jumps now and then | Usually tracking recovering, followed by a re-anchor. Look at a tag to settle it. |
| Devices disagree | See "Checking that devices agree". Confirm both show the same survey ID. |
| Wrong room | Scan the right room's code. |

## 9. Files the app keeps

In the app's folder (iPhone: Files → On My iPhone → Locator; Quest:
`/sdcard/Android/data/edu.utexas.tacc.locator/files/`):

- `room_config.json`: the room from the last code scanned (the remembered room)
- `learned_tags.json`: tags learned on this device
- `locator.log`: the session log, which helps the developers when something
  goes wrong

Deleting the app forgets the room, so the next start asks for the code again.

## 10. Installing

**Quest:** the app is sideloaded, so the headset needs developer mode on. It
appears under **Library → Unknown sources**.

**iPhone:** the app is installed from Xcode with a development profile. The
first time, trust the developer in **Settings → General → VPN & Device
Management**. With a free Apple developer account, the app **stops opening
after 7 days** and must be reinstalled, and a phone can hold only **three**
such apps at once.
