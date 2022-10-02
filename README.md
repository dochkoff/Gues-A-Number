# Gues-A-Number Game

This is simple console game "Guess A Number"

<p>
<img alt="Image" width="350"px src="https://user-images.githubusercontent.com/74410756/193465416-d319a3b8-5690-4d7b-8e53-4a87237eac6a.png">
</p>

## Overview
Guess A Number is a simple console game where the player has to guess the number chosen by his opponent (the computer). On each attempt, you will be given a hint whether the entered number is higher or lower than the expected number.

The game has three levels of difficulty, with each subsequent level your attempts to guess the number decrease.
Win the game after beating the third level.
Good luck!

## Input and Output
Choose number between `1` and `100` then press `Enter`.

The computer select random number, then returns information whether the number is less than, greater than or equal to the selected number.

## Solution
- Create a variable from type "Random", which will help us choose a number randomly by using the method "Next()". We will use this method so each time the computer can choose a number between "1 and 100" randomly.
- With conditional statements switch-case we check on which level is the player.
- With a while-loop to iterate, until the player guesses the computer's random number. 
- Now check the player's input using the int.TryParse() method. It will review the input data and return us "true" or "false" depending on the data submitted by the player. If It's a number (what we expect) the method will return "true" otherwise "false".
- If data is valid a nested if-else statement will check all three possible cases. 
  - First, if the player's number is equal to the computer's number that means the player guessed the computer's number, we write a message, and stop the application by using the keyword "break". 
  - The other two cases are if the player's number is higher than the computer's number and the player’s number is less than the computer's number.
- In the last if statement we check the number of tries.

## Source Code
[Source code of the project](GuessANumber.cs)

## Screenshots
<img width="167" alt="Screen Shot 2022-10-02 at 22 47 35" src="https://user-images.githubusercontent.com/74410756/193476862-55b2fad9-3a5f-4795-8c48-6a9cab64e169.png"> <img width="167" alt="Screen Shot 2022-10-02 at 22 48 16" src="https://user-images.githubusercontent.com/74410756/193476865-0ea646ea-14c0-491e-bb73-a90511890cdb.png"> <img width="167" alt="Screen Shot 2022-10-02 at 22 49 33" src="https://user-images.githubusercontent.com/74410756/193476869-8f9d9871-6b54-47a1-84c3-29b05973e9b2.png">

## One-Click Live Demo

[<img alt="Play" src="https://user-images.githubusercontent.com/74410756/193477520-ba86bbff-a312-4dbf-942a-c24e902073f7.png">](https://replit.com/@Dochkoff/Guess-A-Number#Main.cs)

