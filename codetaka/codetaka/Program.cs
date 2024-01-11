using System;

Solution sol = new Solution();
int[] numbers = { 1, 2, 3, 4, 5, 6 };
double result = sol.solution(numbers);
Console.WriteLine(result);

public class Solution
{
    public double solution(int[] numbers)
    {
        double temp = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            temp += numbers[i];
        }
        double answer = temp / numbers.Length;
        return answer;
    }
}