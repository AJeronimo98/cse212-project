using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // 1. Create a new array of doubles called 'result' with a size equal to the 'length' parameter.
        // 2. Use a 'for' loop that starts at 0 and continues until it reaches 'length'.
        // 3. Inside the loop, calculate each multiple by multiplying 'number' by (i + 1). 
        //    (i + 1) ensures the first multiple is the number itself (e.g., 7 * 1).
        // 4. Store the calculated multiple in the corresponding index 'i' of the 'result' array.
        // 5. Return the populated 'result' array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'. For example, if the data is 
    /// {1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// {7, 8, 9, 1, 2, 3, 4, 5, 6}. The value of amount will be in the range of 1 to data.Count, inclusive.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1. Calculate the starting index for the slice that needs to be moved.
        //    This is done by subtracting 'amount' from the total count of the list.
        // 2. Use the 'GetRange' method to extract the elements from the starting index to the end of the list.
        // 3. Remove those same elements from their original position at the end of the list using 'RemoveRange'.
        // 4. Use 'InsertRange' to place the extracted elements at the very beginning of the list (index 0).

        // Step 1: Find where to split the list
        int splitIndex = data.Count - amount;

        // Step 2: Get the segment that will move to the front
        List<int> rotatedSegment = data.GetRange(splitIndex, amount);

        // Step 3: Remove that segment from the back
        data.RemoveRange(splitIndex, amount);

        // Step 4: Insert the segment at the front
        data.InsertRange(0, rotatedSegment);
    }
}