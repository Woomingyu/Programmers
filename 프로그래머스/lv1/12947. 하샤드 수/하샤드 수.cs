public class Solution {
    public bool solution(int x) {
        
        //하샤드 수를 처음 들어봤다. => 자연수 중 각 자릿수의 합으로 나누어 떨어지는 수
        //하샤드 수 18 : 1+8 = 9 || 18 / 9 = 2 나누어 떨어짐 || 12도 동일
        
        bool answer = true;                       
        int num = 0;
        
        int originX = x; //입력값 보존
        
        //입력값의 모든 자릿수 더하기
        while(x>0)
        {
            num += x % 10;
            x = x / 10;
        }
        //15열의 x는 대입값이 num이므로 원본 x에 변화를 줄 수 없다.
        //입력값이 13이라고 했을 때, 첫 반복에서 x / 10 에 의해 값이 1.3이 되어 1을 반환하고
        //두번째 반복에서 0.1이 되어 0을 반환하므로 while 반복이 멈추게 된다.
        
        answer = (originX % num == 0) ? true : false;
        
        return answer;
    }
}