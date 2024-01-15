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

public class Solution2
{
    public int solution(int n)
    {
        int answer = 0;
        do
        {
            answer += n % 10;
            n /= 10;
        } while (n > 0);
        return answer;
    }
}

public class Solution3
{
    public int solution(int n)
    {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) answer += i;
        }

        return answer;
    }
}