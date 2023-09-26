using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        
        //System.Collections.Generic;
        
        //정답의 길이를 알 수 없으므로 List선언
        List<int> answer = new List<int>();
        
        //학생과 답안의 배열을 가지는 2차원 배열 선언
        int[][] students = new int[3][];
        
        //각 학생에게 그들이 가질 답안의 배열을 입력
        students[0] = new int[] {1,2,3,4,5};
        students[1] = new int[] {2,1,2,3,2,4,2,5};
        students[2] = new int[] {3,3,1,1,2,2,4,4,5,5};
        
        
        //점수 저장용
        int[] score = new int[3] {0,0,0};
        
        
        //정답의 길이만큼 반복 
        for(int i = 0; i < answers.Length; i++)
        {
            //정답 길이 * 3(학생 수)만큼 반복
            for(int j = 0; j < score.Length; j++)
            {
                //답안의 길이가 맞지 않는 경우를 위해 i%students[j].Length를 진행한다.
                if(students[j][i%students[j].Length] == answers[i])
                    score[j]++; //해당 학생의 스코어 순번에 값을 1 더한다.
            }
        }
        
        //스코어(학생 수)만큼 반복
        for(int i = 0; i < score.Length; i++)
        {
            //System.Linq
            //i번째 학생의 점수가 배열의 최대값과 같다면
            if(score[i] == score.Max())
                answer.Add(i+1); //return 값의 List에 해당 학생을 추가 (학생의 번호는 1,2,3 이므로 +1)
        }
        
        //리스트를 '배열' 반환
        return answer.ToArray();
    }
}