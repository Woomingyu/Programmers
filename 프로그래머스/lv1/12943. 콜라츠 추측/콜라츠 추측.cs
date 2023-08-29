public class Solution {
    public int solution(int num) {
         
        //각 변수의 long int 정의에서 조금 실수가 있었다.
        long num2 = num ;
        int answer = 0;
        
        while(num2 != 1)
        {
            ++answer;
            
            if(num2 % 2 == 0)
                num2 = num2 / 2;
            else
                num2 = num2 * 3 + 1 ;
            
            
            
            if (answer >= 500)
                return -1; // 500번 이상 반복하면 -1을 반환
        }

        
        return answer;
    }
}