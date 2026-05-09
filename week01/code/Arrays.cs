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

        /*
        Step1: Create a double array with the requested length
        Step2: Use a loop to iteriate through each index of the array
        Step3: For each position, calculate the multiple number. Start with times 1, times 2, etc.
        Step4: Store each multiple in the array
        Step5: Return the complete array
        */
        
        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
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
        /*
        Step1: Locate the index where rotation list starts. Rotated to the right means the last values moves to the front, i.e. Fot 9 values and amout 3, the start index is 9-3=6
        Step2: Copy the last amount values into a temporary list. They will turn into the rotated list
        Step3: Copy the remaining values from the beginning of the list. These last values will come after the moved values.
        Step4: Clear the original list. This one just modifies the existing list instead of returning a new list
        Step5: Add the values back in the rotated order   
        */

        int startInd = data.Count - amount;
        List<int> movedValues = data.GetRange(startInd, amount);
        List<int> remainingValues = data.GetRange(0, startInd);

        data.Clear();

        data.AddRange(movedValues);
        data.AddRange(remainingValues);
    }
}
