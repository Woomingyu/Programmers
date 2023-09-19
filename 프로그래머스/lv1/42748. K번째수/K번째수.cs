using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) 
    {
        //1.*commands는 [i,j,k]를 여러개 가진 2차원 배열이다.
        
        //answer를 2차원 배열의 행 갯수(배열 요소의 수-여기선{},{},{}를 가지니 3) 만큼 초기화
        int[] answer = new int[commands.GetLongLength(0)];
        
        //0부터 commands 2차원 배열의 행 갯수까지 반복
        for(int n = 0; n < commands.GetLongLength(0); n++)
        {
            //각 행의 i, j, k 원소를 얻기
            int i = commands[n, 0];
            int j = commands[n, 1];
            int k = commands[n, 2];
            
            //i 번째 부터 j 번째 까지 자른 배열 선언(따로 메서드를 사용하지 않고 더 큰 수 j에 i+1 만큼 빼주면 되었다.)
            //j - i 이후에 +1 해주지 않으면 배열 범위를 벗어나게 되는 상황이 생긴다.
            int[] temp = new int[(j - i) + 1];
            
            //자른 배열 크기 만큼 숫자 대입
            for(int a = 0; a<temp.Length; a++)
            {
                temp[a] = array[a+i-1]; //commands의 각 요소는 무조건 1 이상이므로 -1 해도 문제가 없다.
            }
            //자른 배열 정렬
            Array.Sort(temp);
            
            //k 번째 숫자를 answer배열에 대입
            answer[n] = temp[k-1];
        }
        
        //다시공부★
        return answer;
    }
}