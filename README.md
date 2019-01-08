# HoloLens Escape Room App

## Build and deploy instructions instructions
1. Open the the MorseCodeGraph scene located in HoloEscapeRoom\Assets\Scenes
2. File -> Build Settings...
3. Select Universal Windows Platform as the platform
4. Make sure the settings are:
  * Target type: HoloLens
  * Build Type: D3D
  * SDK: Latest installed
  * Build and Run on: Local machine
5. Click build
6. Select the FinalBuild folder


## The Puzzle
This escape room puzzle will contain three different morse code messages, each represented differently. One message will be represented using dots and dashes printed on paper, one will be represented using light flashing on a screen, and the last message will be represented by audio. The morse code messages will placed around the room for the players to solve, as shown in the design below. 

![Alt text](PuzzleDesign.png?raw=true "Puzzle Design")

To complete the puzzle the player must enter the correct answer on the device in the middle of the room. The morse code messages will lead the player to the answer. 

For the prototype the three morse code messages will be random words generated on https://www.randomwordgenerator.com/. 

The audio message is - key

The light message is - tree

The dots and dashes message is - break

The audio and light messages are shorter because they will be harder to translate and I do not want the puzzle being too difficult for players.
