public class Solution {
    public string solution(string s) {
        string answer = "";
        
        //짝수 = 중간과 중간+1의 문자가 중간 글자에 해당함
        if(s.Length % 2 == 0)
            {
            //안쪽의 배치 순서도 중요함(거꾸로 적으면 we 나와야 하는데 ew나옴)
                answer += s[s.Length / 2 - 1];
                answer += s[s.Length / 2];
            }
        //홀수 = 중간이 중간 글자에 해당함
        else
        {
            answer += s[s.Length / 2]; //알아서 소수점을 제거 한다.
        }
        return answer;
    }
    //고급 코드
    //문자열에 .Substring(매개변수1, 매개변수2)의 구조를 가진 메소드는
    //문자열을 '잘라주는' 기능을 한다.
    //매개변수 1로 문자열을 자르기 시작할 index값을 지정하고(0시작, 범위벗어나면 안됨)
    //매개변수 2는 어느 길이만큼 자를 것인지 의미
    //1이면 한글자, 5라면 5글자임(index값이 아니라 단순이 문자 개수이므로 주의)
    //매개변수 2는 생략 가능하며, 이 경우 문자열 끝까지이다.
    
    //목표 1. 매개변수2의 값이 홀수는 1, 짝수는 2가 되어야 한다.
    //목표 2. 매개변수1의 값이 홀수는 문자열 길이 절반, 짝수는 절반에서 -1의 값
    //여기서 조건문을 사용하면 간단하지만, 매개변수를 이용하는 방법도 있다.
    //매개변수2 = (s.Length+1) % 2 기본 코드에 +1 사용하면 홀 짝 0, 1
    //다음으로으로 매개변수2에 +1 해주면 원하는 값인 1, 2를 얻을 수 있다.
    //다음 목표
    //홀수는 문자열 길이 절반값, 짝수는 절반 -1의 값
    //우선 절반값 매개변수1 = s.Length/2 홀 짝 둘다 절반값이 됨
    //짝수일 때 -1이 되어야 한다.
    //매개변수 2를 사용한다. 각각 0, 1이므로 -해주면 원하는 값인
    //홀수 0 , 짝수 -1을 얻을 수 있다. int num1 = (s.Length / 2) - num2;
    // 문자열길이 + 1에서 2로 나눈 나머지를 구한다 => 홀수면 0 / 짝수면 1
    /*
        int num2 = (s.Length + 1) % 2;
        
        int num1 = (s.Length / 2) - num2;
            
        return s.Substring(num1, num2 + 1);
    */
    
}