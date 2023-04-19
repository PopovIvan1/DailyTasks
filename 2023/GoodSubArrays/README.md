# Good subarrays

## **Description**

For integer array nums and integer value k find count of "good" arrays.
Good array - array, in which the number of distinct integers is k.
For example: array [1, 2, 3, 1, 2] contains 3 distinct integers: 1, 2 and 3.

Note: subarray - contiguous part of the array.

## **Examples**

### **Example 1**

Input: nums = [1, 2, 3, 1, 2], k = 2
Result: 7
Explanation: All good subarrays: [1, 2], [2, 1], [1, 2], [2, 3], [1, 2, 1], [2, 1, 2], [1, 2, 1, 2]

### **Example 2**

Input: nums = [1, 2, 1, 3, 4], k = 3
Result: 3
Explanation: All good subarrays: [1, 2, 1, 3], [2, 1, 3], [1, 3, 4]