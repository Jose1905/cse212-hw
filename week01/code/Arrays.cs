public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Solution:
        // Create an empty dynamic array  called  multiplesList
        var multiplesList = new double[length];
        
        // Create a for loop with index i starting with 1, increasing by 1 until i = length
        for (int i = 0; i < length; i++)
        {
            // Insert in the result of number * i into multiplesList
            multiplesList[i] = number * (i+1);
        }        

        return multiplesList; // return multiplesList
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Solution:
        // Create an empty int variable called value
        int value = 0;

        // Create a for loop with index i starting in 0, increasing by 1 until i = (lenght of data - amount)
        for (int i = 0; i < (data.Count - amount); i++)
        {
            // Assign variable value the value of the first element in data
            value = data[0];

            // Remove the first element of data
            data.RemoveAt(0);

            // Add value to the end of data
            data.Add(value);
        }
        
        // print list
        Console.WriteLine(data);
    }
}
