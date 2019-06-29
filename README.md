# snake
Command Line Snake Game! By using asdw controls (and pushing enter between each move)(for now) you can play Snake! Clone the repository, type `dotnet run` in your command line, after you've navigated to the project file of course, and away you go!

I do recommend shrinking your window size to something like 46x13 as it is distracting to see every rendering. A smaller window will make the snake appear to move smoothly and be easier to use.


## How it works
The game is a collection of single squares with a decay time. The decay time dictates how long any square in the matrix will be a segment of a snake or an apple. Each time the head of the snake moves it changes the square it is entering to be a part of the snake with a decay time equal to the maximum length the snake can be. That will increment downwards until zero when it will change back to whitespace.

Apples are unique in that their decay time doesn't change. They still must have a time until they decay, but their time is set to 1000, and any object with a decay time equal to 1000 is not incremented downwards. In this way the apple won't disappear until the snake eats it. The apple functionality would break if the snake grew to be bigger than 1000, but at that point the game breaking should be the least of your problems.
