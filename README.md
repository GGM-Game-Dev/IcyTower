# IcyTower
We implemented a IcyTower like game in Unity 2D engine.

The game have 4 stages where each stage have different Difficulty where the platform size is decreasing and the platform speed acceleration is increasing.

To control the player movement use the Arrow keys and SPACE to jump.

We used rigidBody2D to controll the player movement and gravity.

When the player will hit the Death ground Layer he will die and.


![image](https://user-images.githubusercontent.com/88790441/234013669-4446440d-0027-416b-bb80-7438f8e31caa.png)

## Animations

We implemented an Final State Machine that will controll the player animations state and will be controlled by out playerMovement scripts.

![image](https://user-images.githubusercontent.com/88790441/234014946-230de60a-d25b-456c-8290-706a104d0ede.png)

## Feature

Camera shake- at each new level and when we die we are activating a Camera shake script that will shake the camera.

Floor spawner - Component that will spawn platforms that the player need to step on.

each floor spawned with different speed and size based on the current stage of the game we currently at.
