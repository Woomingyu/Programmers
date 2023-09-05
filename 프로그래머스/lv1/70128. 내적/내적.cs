using System;

public class Solution {
    public int solution(int[] a, int[] b) {
        int answer = 0;
        
        //내적 이라고 하니 애매하고 어떻게 계산해야할지 모르겠지만
        //식 자체는 a[0]*b[0]+a[1]*b[1]+ ... +a[n-1]*b[n-1] 을 진행하고, 
        //그 값을 반환하면 된다. 코드로 바꾸면 어렵지 않다.
        
        //반복문으로 해당 배열순서의 정수를 곱해 answer에 더함.
        for(int i=0; i<a.Length; i++)
        {
            answer += a[i] * b[i];
        }
        
        return answer;
    }
}