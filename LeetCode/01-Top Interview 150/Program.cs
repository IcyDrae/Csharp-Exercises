using RemoveElement;

Solution solution = new Solution();

// Test cases
// Output: 2, nums = [2,2,_,_]
Console.WriteLine(
    solution.RemoveElement([3,2,2,3], 3)
);
// Output: 5, nums = [0,1,4,0,3,_,_,_]
Console.WriteLine(
    solution.RemoveElement([0,1,2,2,3,0,4,2], 2)
);
