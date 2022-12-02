Write a function that takes an amount of US currency cents (cents) and returns a dictionary/hash that shows the smallest number of coins used to create that amount. 
Only coin denominations are considered: Pennies (1¢), Nickels (5¢), Dimes (10¢) and Quarters (25¢). 
So the returned dictionary must contain exactly 4 key/value pairs.

Notes:
• If either 0 or a negative number is passed to the function, then it must return a dictionary with all values ​​equal to 0.
• If a float value is passed to the function, then its value must be rounded down, and the resulting dictionary must never contain fractions of a coin.

Example: 
my_function(56) -> {'Nickels': 1, 'Pennies': 1, 'Dimes': 0, 'Quarters': 2}
my_function(-435) -> {'Nickels': 0, 'Pennies': 0, 'Dimes': 0, 'Quarters': 0}
my_function(4.935) -> {'Nickels': 0, 'Pennies': 4, 'Dimes': 0, 'Quarters': 0}