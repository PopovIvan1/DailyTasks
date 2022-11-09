A smooth sentence is one where the last letter of each word is identical to the first letter the following word (and not case sensitive, so "A" would be the same as "a").

The following would be a smooth sentence "Carlos swam masterfully" because "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".

Create a function that determines whether the input sentence is a smooth sentence, returning a boolean value true if it is, false if it is not.

Examples

IsSmooth("Marta appreciated deep perpendicular right trapezoids") ➞ true

IsSmooth("Someone is outside the doorway") ➞ false

IsSmooth("She eats super righteously") ➞ true

Notes

The last and first letters are case insensitive.
There will be no punctuation in each sentence.