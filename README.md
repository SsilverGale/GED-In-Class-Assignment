Jacob Coleman 100829087
Title: Number Catz

Description: There will be a number on your screen from 0-9. Press the number key coorilating to the number on screen to create a cat

Diagram: https://www.figma.com/board/pe5Bu7F2WvfeBRKnj04Bec/Number-Catz?node-id=1-2&t=jYXvQgZmO5WxJGId-1 

Reflection:

What system within your project uses a Singleton, and why did you choose this system to adopt the pattern? 

I did the game manager, which in my case was used to store global variables and have global functions.
Since it kept track of score, amugst other variables, the project wouldn't really work if htere was more than 1 of them so a singleton was the perfect format for this project.
It also makes it much easier to access all of these variables with other objects in the scene.

Do you think this design pattern is beneficial for this purpose? Explain why or why not.

I feel like it was benefitial as it was much easier to access the variables. However it was also unessisary as not many variables were really used in more than 1 script.
