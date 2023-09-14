using System;

public class Solution {
    public int solution(int[,] sizes) {
        
        int max1 = 0;
        int max2 = 0;
        
        //.GetLength(0) == 행의 개수[1,2,3....] & .GetLength(1) == 열의 개수 sizes 이차원 배열의 길이
        
        //이 부분에선 i에 포함된 인자들을 확인해야하므로 행을 검사해야한다.
        //기존 i번째가 현재 i번째보다 작은 경우에만 기존 i를 현재 수치로 변경 후 저장
        for(var i=0; i< sizes.GetLength(0); i++)
        {
            var temp = 0;
            if(sizes[i, 0] < sizes[i, 1])
            {
                temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }   
        }
        

        //위 반복에서 수정된 상태의 sizes 이차원 배열을 반복
        //변수값의 현재 크기에 따라 sizes 이차원 배열을 각 변수에 할당
        for (var i = 0; i < sizes.GetLength(0); i++)
        {
            if (max1 < sizes[i, 0]) 
                max1 = sizes[i, 0];
            
            if (max2 < sizes[i, 1]) 
                max2 = sizes[i, 1];
        }
        
        int answer = max1 * max2;

        //★이 문제도 내일 또 보고 이해안가면 튜터님께 질문
        return answer;
    }
}