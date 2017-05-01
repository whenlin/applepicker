 Apple Picker

By: Alexander Powell and William Henlin 

This project includes:
Part1 - This has all project scenes up to scene8
Part2 - This contains just scene0 and is the final game
Screenshots - This contatins the screenshots from testing on different scenes as described in the project requirements
ApplePicker Project - This is the file that was used to make the project and has all scenes in it.

***
Please Note: for the later scenes in the project, there are no game objects in the scene before the game starts. This is intentional, the game instantiates all game objects and keeps track of them. 
The ApplePicker script instantiates the correct number of baskets for the projects, the AppleTree script instantiates the AppleTree object and describes its behaviour, 
this ensures that the project uses the prefab created in scene 2 without creating multiple copies of the AppleTree and works similar to the singleton design pattern. 
This could have been done with the AppleTree already in the scene but then the prefab created earlier would be unused. 
This required adjusting the script a bit so that is could facilitate this change. The AppleTree script is then attached to the main camera.
***

###Part 1
This contain the parts of the project up to scene 8.

###Part 2
This contains scene 0 and the final project

###Screenshots
