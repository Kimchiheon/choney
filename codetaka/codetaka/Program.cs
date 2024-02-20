using System;
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

//public class Solution
//{
//    public int solution(int num)
//    {
//        long answer = num;
//        int temp = 0;
//        for (int i = 0; i < 500; i++)
//        {
//            if (answer == 1) return temp;
//            if (answer % 2 == 0) answer /= 2;
//            else { answer = (answer * 3) + 1; }
//            temp++;

//        }
//        return -1;
//    }
//}


//public class Solution
//{
//    public string solution(string[] seoul)
//    {
//        string answer = "";
//        string temp = "";
//        for (int i = 0; i < seoul.Length; i++)
//        {
//            if (seoul[i] == "Kim")
//            {
//                answer = $"김서방은 {i}에 있다";
//                return answer;
//            }
//        }
//        return answer;
//    }
//}

//using System;

//public class Solution
//{
//    public int solution(int[] absolutes, bool[] signs)
//    {
//        int answer = 0;
//        for (int i = 0; i < absolutes.Length; i++)
//        {
//            if (signs[i]) answer += absolutes[i];
//            else answer -= absolutes[i];
//        }

//        return answer;
//    }
//}

//public class Solution
//{
//    public string solution(string phone_number)
//    {
//        char[] chars = phone_number.ToCharArray();
//        int number = chars.Length;
//        for (int i = 0; i < number - 4; i++)
//        {
//            chars[i] = '*';
//        }

//        string answer = new string(chars);
//        return answer;
//    }
//}
//using System;

//public class Solution
//{
//    public int solution(int[] numbers)
//    {
//        int temp = 0;
//        int answer = -1;
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            temp += numbers[i];
//        }
//        answer = 45 - temp;
//        return answer;
//    }
//}


//using System.Linq;

//public class Solution
//{
//    public string solution(string s)
//    {
//        string answer = "";
//        char[] array = s.ToArray();
//        if (array.Length % 2 == 0)
//        {
//            string temp = array[array.Length / 2 - 1].ToString() + array[(array.Length / 2)].ToString();
//            answer = temp;
//        }
//        else
//        {
//            string temp = array[(array.Length / 2)].ToString();
//            answer = temp;
//        }
//        return answer;
//    }
//}

//public class Solution
//{
//    public string solution(int n)
//    {
//        string answer = "";
//        for (int i = 0; i < n; i++)
//        {
//            if (i % 2 == 0) answer += "수";
//            if (i % 2 == 1) answer += "박";
//        }

//        return answer;
//    }
//}

//using System;

//public class Solution
//{
//    public int solution(int[] a, int[] b)
//    {
//        int answer = 0;
//        for (int i = 0; i < a.Length; i++)
//        {
//            answer += a[i] * b[i];
//        }
//        return answer;
//    }
//}

//using System;

//public class Solution
//{
//    public int solution(int left, int right)
//    {
//        int answer = 0;
//        for (int i = left; i <= right; i++)
//        {
//            int temp = i;
//            float rooti = MathF.Sqrt(i);
//            if (rooti % 1 == 0) temp *= -1;
//            answer += temp;
//        }
//        return answer;
//    }
//}

//using System.Linq;

//public class Solution
//{
//    public string solution(string s)
//    {
//        string answer = "";
//        char[] chars = s.ToCharArray();
//        char[] sortArray = sortArray = chars.OrderByDescending(n => n).ToArray();
//        answer = new string(sortArray);

//        return answer;
//    }
//}

using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long curPrice = price;
        long sum = 0;
        long answer = 0;

        for (int i = 1; i <= count; i++)
        {
            curPrice = price * i;
            //if (curPrice >= 2500)
            //{
            //    curPrice = 2500;
            //}
            sum += curPrice;
        }
        answer = sum - money;
        if (money > sum) { return 0; }
        else return answer;
    }



}



