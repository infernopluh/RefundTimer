# RefundTimer

A simple mod designed to close gorilla tag within the time you need before you cant refund on steam.

## Features

- Closes the game after 1 hour 58 minutes (7080 seconds)
- Saves the remaining time to a file
- Resumes countdown on next launch
- Displays time left in-game (top left corner)

## Installation

1. **Build** the project (make sure you have referenced `BepInEx.dll` and `UnityEngine.dll`).
2. Place the resulting `RefundTimer.dll` in your `BepInEx/plugins` folder.
3. Launch your game.

## Usage

- The mod will automatically track your playtime.
- When you have played for 1 hour and 58 minutes (total), the game will automatically close.
- The remaining time is saved in `BepInEx/plugins/RefundTimer/timerdata.txt`.
- If you close the game early, your time left will be saved and picked up next time you start the game.

## Customization

- To change the total allowed time, edit the `MaxPlaySeconds` constant in `RefundTimer.cs` and rebuild.

## Credits

- Made by [yourname]
- Inspired by refund policies and good time-management.

---
**Note:** This product is not affiliated with Gorilla Tag or Another Axiom LLC and is not endorsed or otherwise sponsored by Another Axiom LLC. Portions of the materials contained herein are property of Another Axiom LLC. © 2021 Another Axiom LLC.
