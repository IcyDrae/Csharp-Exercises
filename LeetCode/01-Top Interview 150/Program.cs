using SearchInsertPosition;

Solution solution = new Solution();

// Test cases
// Output: 2
Console.WriteLine(
    solution.SearchInsert([1,3,5,6], 5)
);
// Output: 1
Console.WriteLine(
    solution.SearchInsert([1,3,5,6], 2)
);
// Output: 4
Console.WriteLine(
    solution.SearchInsert([1,3,5,6], 7)
);

