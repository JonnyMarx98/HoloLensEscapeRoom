# HoloLens Escape Room App

## Build and deploy instructions instructions
There is a build in the Finalbuild folder, however here are the instructions for building and deploying if necessary 

1. Open the the MorseCodeGraph scene located in HoloToolkitTest\Assets\Scenes
2. File -> Build Settings...
3. Select Universal Windows Platform as the platform
4. Make sure the settings are:
  * Target type: HoloLens
  * Build Type: D3D
  * SDK: Latest installed
  * Build and Run on: Local machine
5. Click build
6. Select the FinalBuild folder
7. Open HoloToolkitTest.sln located in the FinalBuild folder

8. Follow the instruction in HoloLensDeployInstructions.pdf to deploy


## The Puzzle
This escape room puzzle will contain four different morse code translation task, each represented differently. One message will be represented using dots and dashes printed on paper, one will be represented using light flashing on a screen, one will be text that needs to be translated into morse code, and the last message will be represented by audio. The morse code messages will placed around the room for the players to solve, as shown in the design below. 

![Alt text](PuzzleDesign.png?raw=true "Puzzle Design")

To complete the puzzle the player must enter the correct answers on the device in the middle of the room.
