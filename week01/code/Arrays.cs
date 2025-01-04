public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // Initialize an array of the given length
        double[] multiples = new double[length];

        // Loop through the array to calculate multiples
        for (int i = 0; i < length; i++)
        {
            // Set the value at each index to be the multiple of the number
            multiples[i] = number * (i + 1);
        }

        // Return the array of multiples
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Early exit if no rotation is needed
        if (data.Count == 0 || amount == 0)
        {
            return;
        }

        // Reduce the amount to avoid unnecessary rotations
        amount %= data.Count;

        // Get the last 'amount' elements and the first part of the list
        var lastPart = data.GetRange(data.Count - amount, amount);
        var firstPart = data.GetRange(0, data.Count - amount);

        // Clear the original list and add the rotated parts in the new order
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
