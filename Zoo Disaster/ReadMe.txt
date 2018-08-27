https://www.codewars.com/kata/the-hunger-games-zoo-disaster/train/csharp

Story
A freak power outage at the zoo has caused all of the electric cage doors to malfunction and swing open...
All the animals are out and some of them are eating each other!
It's a Zoo Disaster!
Here is a list of zoo animals, and what they can eat
o	antelope eats grass
o	big-fish eats little-fish
o	bug eats leaves
o	bear eats big-fish
o	bear eats bug
o	bear eats chicken
o	bear eats cow
o	bear eats leaves
o	bear eats sheep
o	chicken eats bug
o	cow eats grass
o	fox eats chicken
o	fox eats sheep
o	giraffe eats leaves
o	lion eats antelope
o	lion eats cow
o	panda eats leaves
o	sheep eats grass
Kata Task
INPUT
A comma-separated string representing all the things at the zoo
TASK
Figure out who eats who until no more eating is possible.
OUTPUT
A list of strings (refer to the example below) where:
o	The first element is the initial zoo (same as INPUT)
o	The last element is a comma-separated string of what the zoo looks like when all the eating has finished
o	All other elements (2nd to last-1) are of the form X eats Y describing what happened
Notes
o	Animals can only eat things beside them
o	Animals always eat to their LEFT before eating to their RIGHT
o	Always the LEFTMOST animal capable of eating will eat before any others
o	Any other things you may find at the zoo (which are not listed above) do not eat anything and are not edible
Example
	INPUT	"fox,bug,chicken,grass,sheep"
1	fox can't eat bug	"fox,bug,chicken,grass,sheep"
2	bug can't eat anything	"fox,bug,chicken,grass,sheep"
3	chicken eats bug	"fox,chicken,grass,sheep"
4	fox eats chicken	"fox,grass,sheep"
5	fox can't eat grass	"fox,grass,sheep"
6	grass can't eat anything	"fox,grass,sheep"
7	sheep eats grass	"fox,sheep"
8	fox eats sheep	"fox"
	OUTPUT	["fox,bug,chicken,grass,sheep", "chicken eats bug", "fox eats chicken", "sheep eats grass", "fox eats sheep", "fox"]
