using System;

public class Solution {
    public int solution(int left, int right) {
        
        int answer = 0;
        
        //left~right
        for(int i=left; i<=right; i++)
        {
            int count=0;
            
            //약수의 개수 count 구하기
            for(int j=1; j<=i; j++)
            {
                //약수 구하기 (i : 주어진 수, j : 해당 수의 약수 후보)
                if(i%j==0) count++;
            }
            
            //내부 반복문(약수의 개수 count 구하기) 종료 후 결과값에 가감하기
            
            
            //해당 반복의 수가 짝수인 경우 + (i의 약수가 짝수로 존재)
            if(count%2==0) answer += i;
            //해당 반복의 수가 홀수인 경우 - (i의 약수가 홀수로 존재)
            else answer -= i;
        }
        return answer;
    }
}