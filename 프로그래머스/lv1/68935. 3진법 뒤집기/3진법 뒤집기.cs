using System;
using static System.Math;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        //3진법의 리스트 생성(반전용)
        List<int> list = new List<int>();
        
        //자연수 n이 0이 될 때 까지 나눈 나머지를 list에 저장
        while(true)
        {
            if(n==0) 
                break;
            
            //이 과정을 통해 n이 0이 되기 전까지 계속 리스트에 수 d를 추가한다. 45 = 0,0,2,1
            //자연수(10진법)를 3진법으로 변환하는법을 알았다.
            //각 자릿수에 n%3을 넣은 뒤, n/3을 통해 뒤에 수가 더 있는지 확인, 다음수를 변경한다.
            int d = n%3;
            list.Add(d);
            n = n/3;
        }
        //앞뒤 뒤집기 list.Reverse()
        list.Reverse();
        
        //뒤집은 list의 나머지 값 * 3의 거듭 제곱을 곱해 answer에 더하기
        //위에서 한 연산을 반대로 하려면 거듭 제곱을 하면 된다.
        for(int i = 0; i<list.Count; i++)
        {
            answer += (int)(list[i] * Math.Pow(3,i));
        }
        return answer;
    }
}