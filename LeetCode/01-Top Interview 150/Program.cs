using RemoveDuplicatesII;

Solution solution = new Solution();

// Test cases
// Input: nums = [1,1,1,2,2,3]
// Output: 5, nums = [1,1,2,2,3,_]
Console.WriteLine(
    solution.RemoveDuplicates([1,1,1,2,2,3])
);
// Input: nums = [0,0,1,1,1,1,2,3,3]
// Output: 7, nums = [0,0,1,1,2,3,3,_,_]
Console.WriteLine(
    solution.RemoveDuplicates([0,0,1,1,1,1,2,3,3])
);
