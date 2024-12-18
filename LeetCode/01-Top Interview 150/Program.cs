using TwoSum;

Solution solution = new Solution();

// Test cases
Console.WriteLine(string.Join(",", solution.TwoSum(new int[] { -1, -2, -3, -4, -5 }, -8))); // Output: [2,4]
Console.WriteLine(string.Join(",", solution.TwoSum(new int[] { -3, 4, 3, 90 }, 0)));       // Output: [0,2]
Console.WriteLine(string.Join(",", solution.TwoSum(new int[] { 0, 4, 3, 0 }, 0)));         // Output: [0,3]
Console.WriteLine(string.Join(",", solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9)));       // Output: [0,1]
Console.WriteLine(string.Join(",", solution.TwoSum(new int[] { 3, 2, 4 }, 6)));            // Output: [1,2]
Console.WriteLine(string.Join(",", solution.TwoSum(new int[] { 3, 3 }, 6)));               // Output: [0,1]


