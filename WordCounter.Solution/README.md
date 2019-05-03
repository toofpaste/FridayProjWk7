# _Word Counter_

#### _a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence._

#### By _**Michael Larragueta**_

## Description

_a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence._

## Setup/Installation Requirements

* _Clone from GitHub_
* _Open index.html_
* _Alternatively, launch toofpaste.github.io/FridayProjWk5_

## Specs

| Behavior | Input | Output | 
| ------------- |:-------------:| -----:| 
| Takes in a sentence as a string makes it lowercase | The Cat Is large | "the cat is large" | 
| Take in a word to check and makes it lowercase | Cat | "cat" | 
| Split the string sentence into each word in a string array | "the cat is large" | {"the", "cat", "is", "large"} | 
| check each element of the array for the check word | the == cat | false | 
| if the above is true add 1 to our word count| (cat = cat) is true | word count + 1 | 
| make sure words containing partial words (cat) do not count | cat == cathederal | false | 
| print out the user sentence, the word that was checked, and how many times it was found | submit | The word "Cat" appears *wordCount* times in the sentence "The Cat Is large" has 1 | 


## Known Bugs

_Possible Spelling errors_

## Support and contact details

_Please contact me at m.larragueta@yahoo.com if you run into any issues or have questions, ideas or feedback._

## Technologies Used

_C#, PowerShell, Visual Studio 2017, .NET_

### License

*This software is licensed under the GPL license.*

Copyright (c) 2019 **_Michael Larragueta_**