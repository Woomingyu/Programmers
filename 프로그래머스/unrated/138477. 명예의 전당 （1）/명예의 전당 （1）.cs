using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        //1.k일 까지는 모든 가수의 점수가 명예의 전당에 오른다.
        //2.k일 이후 부터는 다음 가수의 점수가 k번째 가수의 점수보다 높다면, 명예의 전당에 오르고 기존 k번째 순위를 제거한다.
        //3.명예의 전당 순위를 내림차순 배치하고 맨 마지막 속성을 발표 점수에 추가하고, 모든 날짜의 최저점 배열을 리턴한다.
        
        //일차 : 스코어 == 일차 이므로 해당 길이만큼 array 선언
        int[] answer = new int[score.Length];
        
        //명예의 전당 : 제거하고 추가하기 편하게 List 선언
        List<int> temp = new List<int>();
        
        //일차 수 만큼 반복
        for(int i = 0; i < score.Length; i++)
        {
            //명예의 전당에 등록된 속성의 총 개수가 k와 같다면(k일차 라면)
            if(temp.Count == k)
            {
                //명예의 전당 0번의 스코어가 i일차 신규 스코어보다 크다면
                if(temp[0] > score[i])
                {
                    //발표 점수 리스트 i번째에 명예의 전당 0번을 입력 후 다음 반복으로 감
                    answer[i] = temp[0];
                    continue;
                }
                //신규 스코어보다 작다면 명예의 전당 0번을 리스트에서 제거
                temp.RemoveAt(0);
            }
            
            //명예의 전당에 신규 스코어 추가
            temp.Add(score[i]);
            //배열 내림차순으로 재배치
            temp.Sort();
            //명예의 전당 리스트에 명예의 전당 0번 추가
            answer[i] = temp[0];
        }
        
        return answer;
    }
}