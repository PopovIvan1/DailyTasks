You are given an input array of bigrams, and an array of words.

Write a function that returns true if every single bigram from this array can be found at least once in an the list of words.

Examples

CanFind(new string[] { "at", "be", "th", au" }, new string[] { "beautiful", "the", "hat" }) ➞ true

CanFind(new string[] { "ay", "be", "ta", cu" }, new string[] { "maybe", "beta", "abet", "course" }) ➞ false
// "cu" does not exist in any of the words.

CanFind(new string[] { "th", "fo", "ma", or" }, new string[] { "the", "many", "for", "forest" }) ➞ true

CanFind(new string[] { "oo", "mi", "ki", la" }, new string[] { "milk", "chocolate", "cooks" }) ➞ false

Notes

A bigram is string of two consecutive characters in the same word.