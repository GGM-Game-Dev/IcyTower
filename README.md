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
![image](https://user-images.githubusercontent.com/88790441/234015729-5cf9bc27-349a-4646-8fb1-1584a5dcbfa4.png)


Floor spawner - Component that will spawn platforms that the player need to step on.
![image](https://user-images.githubusercontent.com/88790441/234015844-9750e213-d785-4203-8503-cd11b00ef79b.png)


each floor spawned with different speed and size based on the current stage of the game we currently at, based on what the GameManager script want.
