using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {        
        //답변의 배열은 동적 확장이 필요
        List<int> answer = new List<int>();
        
        for(int i = 0; i < arr.Length; i++)
        {
            
            if(arr[i] % divisor == 0)
                answer.Add(arr[i]);                              
        }
        
        //위의 for문을 다 돌고도 리스트가 비었다면
        if (answer.Count == 0) 
            answer.Add(-1);
        
        //오름차순 정렬
        answer.Sort();
        //list -> array
        return answer.ToArray();
    }
}