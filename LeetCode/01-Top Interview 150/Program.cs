using RemoveDuplicates;

Solution solution = new Solution();

// Test cases
// Output: 2, nums = [1,2,_]
Console.WriteLine(
    solution.RemoveDuplicates([1,1,2])
);
// Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
Console.WriteLine(
    solution.RemoveDuplicates([0,0,1,1,1,2,2,3,3,4])
);
