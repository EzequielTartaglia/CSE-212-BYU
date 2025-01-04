public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.      
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // Return the array of multiples
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
        // Early exit if no rotation is needed
        if (data.Count == 0 || amount == 0)
        {
            return;
        }

        // Reduce amount to avoid unnecessary rotations
        amount %= data.Count;

        // Split the list into two parts: last 'amount' elements and the rest
        var lastPart = data.GetRange(data.Count - amount, amount);
        var firstPart = data.GetRange(0, data.Count - amount);

        // Clear the original list and add the rotated elements
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }

}
