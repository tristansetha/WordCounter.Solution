# Track suggester

Count the words in any sentence

By Tristan Setha 02/15/18, update 02/22/19

## Description

A word counter that takes an input of a Word and a Sentence and outputs how many words are in the sentence!

## Setup/Installation Requirements

Cloning
<br/>Cloning:
<br/>Download .NET Core 1.1.4 SDK and .NET Core Runtime 1.1.2 and install them. Download Mono and install it.
<br/>Open terminal and $ cd into preferred destination of clone
<br/>Run the command $ git clone https://github.com/tristansetha/WordCounter.Solution
<br/>$ cd into WordCounter.Solution
<br/>To edit: open in preffered text editor

<br/>Running:
<br/>In command prompt or terminal
<br/>Navigate into WordCounter.Solution directoy: $ cd WordCounter.Solution
<br/>Navigate into WordCounter directory: $ cd WordCounter
<br/>while in the WordCounter directory use the commands:
<br/>$ dotnet restore
<br/>$ dotnet run
<br/>Open the path from "Now listening on: http://localhost:5000 in your favorite web browser

<br/>To run tests:
<br/>Run tests:
<br/>in terminal or command prompt navigate to WordCounter.Solution/WordCounter.Tests. 
    <br/>$ cd WordCounter.Tests
<br/>use the command $ dotnet test

## Specs

|   Behavior                          | Input Example | Output Example |
| ------------------------------------|:-------------:| :-------------:|
|  user enters home and clicks the link to form | click link  | form |
|  user enters in a word input with no sentence   | apple | invalid input |
|  user enters in a sentence with no word | the apple | invalid input |
|  user enters in no inputs | | invalid input |
|  User enters in (word),User enters in (sentence)  | apple, The apple tree has an apple |  Word: apple, Sentence: he apple tree has an apple, Count: 2  |
|  User enters in number or symbol in 'any' input | 4ppl&, the apple tree has an apple | invalid input |
|  if any words match the inputted word in sentence add one to counter (eg. sentence: The apple tree has an apple ) | apple | add 2 to counter; Count: 2 |
|  if no words match sentence (eg. sentence: The apple tree has an apple) |  zebra | (add 0 to counter) no words match; Count: 0 |


## Technologies Used

C#, .NetCore 1.1, HTML, Git, Visual Studio code, Mono

ask me anything!!! tristansetha@gmail.com

MIT

Copyright (c) 2019 Tristan Setha
