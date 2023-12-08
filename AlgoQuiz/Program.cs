namespace AlgoQuiz
{
    internal class Program
    {
        // 21. 하샤드의 수
        public bool solution21(int x)
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
        public long solution22(int a, int b)
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

        // 23. 콜라츠 추측
        public int solution23(int num)
        {
            long temp = num;
            // 반복 횟수를 측정
            int answer = 0;
            // 숫자가 1이될때까지 반복한다.
            while (temp != 1)
            {
                // 반복횟수를 1 올려준다.
                answer++;

                // 숫자가 짝수면 나누기 2 , 홀수면 3곱하고 1을 더함
                temp = temp % 2 == 0 ? temp / 2 : temp * 3 + 1;


                // 만약 반복숫자가 500이 넘어버리면
                if (answer > 500)
                {
                    return -1;
                }
            }
            // 몇번 반복했는지 리턴
            return answer;
        }

    static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
