using System;

public class Solution {
    public int[] solution(string s) {        
        //1.각 char의 속성과 위치를 알아놓는다.
        //2.이전 반복에서 나오지 않은 char의 경우 -1로 표현
        //3.이전 반복과 중복되는 속성이 나왔을 경우, 해당 속성과 이전 속성의 배열 순서 차이를 계산하여 반환.
        
        //answer의 길이를 s만큼으로 선언
        int[] answer = new int[s.Length];
        
        //answer의 각 속성을 저장할 변수 (기본 -1로 고정, 중복 시에만 변경, 매 반복 초기화)
        int index = -1;
        
        for(int i = 0; i < s.Length; i++)
        {
            //매 반복 시 초기화
            index = -1;
            
            //내부루프 : j가 0 이상의 양수인 경우에만 반복됨 / 시작값 -1, / 0, 1..
            for(int j = i - 1; j >= 0; j--)
            {
                //현재 위치와 이전 위치의 속성값이 같은지 비교
                if(s[i] == s[j])
                {
                    //만약 같다면 index에 i와 j 사이의 차이를 반환
                    index = i - j;
                    break;
                }
            }
            
            //각 속성에 결과값 배정
            answer[i] = index;
        }
        return answer;
    }
}