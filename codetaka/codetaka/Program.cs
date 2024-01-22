using System;


//int[] numbers = { 1, 2, 3, 4, 5, 6 };
//double result = sol.solution(numbers);
//Console.WriteLine(result);

//public class Solution
//{
//    public double solution(int[] numbers)
//    {
//        double temp = 0;
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            temp += numbers[i];
//        }
//        double answer = temp / numbers.Length;
//        return answer;
//    }
//}

//public class Solution2
//{
//    public int solution(int n)
//    {
//        int answer = 0;
//        do
//        {
//            answer += n % 10;
//            n /= 10;
//        } while (n > 0);
//        return answer;
//    }
//}

//public class Solution3
//{
//    public int solution(int n)
//    {
//        int answer = 0;
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0) answer += i;
//        }

//        return answer;
//    }
//}


//public class Solution4
//{
//    public int solution(int n)
//    {
//        int answer = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (n % (n - i) == 1)
//            {
//                answer = n - i;
//            }

//        }

//        return answer;
//    }
//}

//public class Solution5
//{
//    public long[] solution(int x, int n)
//    {
//        long[] answer = new long[n];
//        for (long i = 0; i < n; i++)
//        {
//            answer[i] = x * (i + 1);
//        }
//        return answer;
//    }
//}

//public class Solution6
//{
//    public int[] solution(long n)
//    {
//        int count = 0;
//        long temp = 0;
//        int[] answer = new int[] { };
//        while (true)
//        {
//            answer[count] = (int)n % 10;
//            temp = n / 10;
//            count++;
//            if (temp < 10) break;
//        }
//        return answer;
//    }
//}

//public class Solution7
//{
//    public int solution(string s)
//    {
//        bool isNum = false;
//        int answer = 0;
//        isNum = int.TryParse(s, out answer);

//        return answer;
//    }
//}


public class Solution
{
    public long solution(long n)
    {
        long x = (int)n / 2;
        while (true)
        {
            if (x * x == n) return (x + 1) * (x + 1);
            if (x * x > n) x = (int)x / 2;
            if (x * x < n)
            {
                x++;
                if (x * x > n) return -1;


            }
        }


    }

}


