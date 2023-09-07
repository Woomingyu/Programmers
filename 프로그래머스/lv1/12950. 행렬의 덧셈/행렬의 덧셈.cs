using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        
        //행과 열의 크기가 arr1, arr2 동일하다고 했으므로 arr1으로 answer[,] 길이를 설정한다.
        int[,] answer = new int[arr1.GetLength(0),arr1.GetLength(1)];
        
        // 2차원 배열이므로 for 두개가 필요하다.
        // 배열 번호 & 값이 필요한데 배열이 두개이므로
        
        //2차원 배열은 길이를 가져올 때 번호를 지정해줘야 한다.
        //arr1.GetLength(가져올 배열 번호)
        
        //흐름 : 0번 배열 * 1번 배열의 길이만큼 반복 -> answer 2차원 배열의 각각 [x,y]에 맞는 arr1+arr2의 값을 넣어줌
        //2차원 배열이라는 개념을 잡아두고 가는 단계같음
        //문제를 풀어보니 훨씬 이해가 잘감
        
             
        for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
        return answer;
    }
}