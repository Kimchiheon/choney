﻿using System;
using System.Linq;


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


//public class Solution
//{
//    public long solution(long n)
//    {
//        long x = (int)n / 2;
//        while (true)
//        {
//            if (x * x == n) return (x + 1) * (x + 1);
//            if (x * x > n) x = (int)x / 2;
//            if (x * x < n)
//            {
//                x++;
//                if (x * x > n) return -1;


//            }
//        }


//    }

//}

//long i = 876652498;
//string str = i.ToString();
//char[] chars = str.ToCharArray();
//char[] sort = chars.OrderByDescending(x => x).ToArray();
//long answer = long.Parse(sort);
//Console.WriteLine(answer);


//public class Solution
//{
//    public bool solution(int x)
//    {
//        bool answer = true;
//        int number = 0;
//        char zero = '0';
//        string str = x.ToString();
//        char[] chars = str.ToCharArray();
//        for (int i = 0; i < chars.Length; i++)
//        {
//            number += (chars[i] - zero);
//        }
//        if (x % number == 0) answer = true;
//        else answer = false;
//        return answer;
//    }
//}

//public class Solution
//{
//    public long solution(int a, int b)
//    {
//        long answer = 0;
//        if (a > b)
//        {
//            for (int i = b; i <= a; i++)
//            {
//                answer += i;
//            }
//        }
//        else if (b > a)
//        {
//            for (int i = a; i <= b; i++)
//            {
//                answer += i;
//            }
//        }
//        else answer = a;

//        return answer;
//    }
//}

public class Solution
{
    public int solution(int num)
    {
        long answer = num;
        int temp = 0;
        for (int i = 0; i < 500; i++)
        {
            if (answer == 1) return temp;
            if (answer % 2 == 0) answer /= 2;
            else { answer = (answer * 3) + 1; }
            temp++;

        }
        return -1;
    }
}


