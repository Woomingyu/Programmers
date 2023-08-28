public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        //a(시작점)이 b(도착점) 보다 작은 경우
        if(a < b)
        {
            for(int i = a; i <= b; i++)
            {
                answer += i;
            }    
        }
        //a(시작점)이 b(도착점) 보다 큰 경우
        else
        {
            for(int i = a; i >= b; i--)
            {
                answer += i;
            }
        }
        
        return answer;
    }
}