# Track suggester

Count the words in any sentence

By Tristan Setha

## Description

A word counter that takes an input of a Word and a Sentence and outputs how many words are in the sentence!

## Setup/Installation Requirements

Cloning
Open terminal and $ cd into preferred destination of clone
Run the command $ git clone https://github.com/tristansetha/word-counter
$ cd into WordCounter
$ mcs Program.cs Models/Word.cs; mono Program.cs

## Specs

|   Behavior                          | Input Example | Output Example |
| ------------------------------------|:-------------:| :-------------:|
|  User enters in alphabetic string (word) | apple |  n/a  |
|  User enters in alphabetic string (sentence) | The apple tree has an apple| n/a |
|  User enters in number or symbol in 'any' input | 4ppl& | please enter a qualifing sentence andor word |
|  if any words match the inputted word in sentence add one to counter (eg. sentence: The apple tree has an apple) | apple | add 2 to counter |
|  if no words match sentence (eg. sentence: The apple tree has an apple) |  zebra | (add 0 to counter) no words match |


## Technologies Used

Mono, C#, Git, Visual Studio code

ask me anything!!! tristansetha@gmail.com

MIT

Copyright (c) 2019 Tristan Setha
