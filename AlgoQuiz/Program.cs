namespace AlgoQuiz
{
    internal class Program
    {

        // 17. 자연수 뒤집어 배열로 만들기
        public int[] solution17(long n)
        {
            string temp = n.ToString();
            int[] answer = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                answer[i] = int.Parse(temp[i].ToString());
            }
            Array.Reverse(answer);
            return answer;
        }

        //18. 문자열을 정수로 바꾸기
        public int solution18(string s)
        {
            int answer = 0;
            answer = int.Parse(s);
            return answer;
        }

        //19. 정수 제곱근 판별

        public long solution19(long n)
        {
            long answer = 0;
            double x = Math.Sqrt(n);
            if (x % 1 == 0)
            {
                answer = ((long)x + 1) * ((long)x + 1);
            }
            else
                answer = -1;

            return answer;
        }

        //20. 정수 내림차순으로 배열하기
        public long solution20(long n)
        {
            long answer = 0;
            // n을 곧장 char형태로 변환해서 새로운 char 배열에 저장함
            char[] temp = n.ToString().ToCharArray();

            // 배열을 오름차순으로 정렬함
            Array.Sort(temp);

            // 배열을 뒤집는다 = 내림차순으로 바뀜
            Array.Reverse(temp);

            // temp배열을 문자열로 만든뒤에 long형태로 변환한다.
            // long이므로 ToInt32가 아니라 64다. 헷갈린다면 그냥 long.Parse를 쓰자.
            answer = Convert.ToInt64(new string(temp));

            // 정답을 리턴함
            return answer;
        }

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
