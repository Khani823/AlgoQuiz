namespace AlgoQuiz
{
    internal class Program
    {
        // 21. 하샤드의 수
        public bool solution(int x)
        {
            bool answer = true;
            int sum = 0; // 각 자릿수의 합이 sum
            int input = x;
            while (x > 0)
            {
                sum += (x % 10);
                x /= 10;
            }

            if (input % sum == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }


        // 22. 두 정수 사이의 합
        public long solution(int a, int b)
        {
            long answer = 0;
            if (a == b)
                return a;
            
            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
            }

            for (int i = a; i <= b; i++)
            {
                answer += i;
            }
            return answer;
        }
    
    static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
