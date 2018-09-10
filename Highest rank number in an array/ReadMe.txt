https://www.codewars.com/kata/highest-rank-number-in-an-array/csharp

>>Highest Rank Number in an Array!<<

Write a method highestRank(arr) (or highest-rank in clojure) which returns the number which is most frequent in the given input array (or ISeq). If there is a tie for most frequent number, return the largest number of which is most frequent.
Example:

var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
Kata.HighestRank(arr) //=> returns 12

arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 };
Kata.HighestRank(arr) //=> returns 12

var arr = new int[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 };
Kata.HighestRank(arr) //=> returns 3