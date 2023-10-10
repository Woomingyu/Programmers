using System;
using System.Linq; // .Contains 사용

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        //1~45까지의 숫자 중 6개를 맞출 수 있음
        //6,5,4,3,2까지의 당첨과 1의 낙첨이 있음
        //낙서 : 알아볼 수 없는 부분을 0으로 처리, 당첨 : 순서에 관계없이 주어진 수와 일치하는지만 체크
        //민우의 수 배열 : lottos, 당첨 번호 : win_nums, answer : 당첨가능한 최고 순위, 최저순위 순서로 배열
        
        int accurate = 0;
        int tempNum =0;
        
        //번호 길이만큼 반복
        for(int i=0; i<lottos.Length; i++)
        {
            //내 번호에서 0인 부분 탐색
            if(lottos[i]==0) 
            {
                //빈 번호 변수에 +1
                tempNum++;
            }
            //array.Contains(@) = 해당 배열에 @가 있는지 체크(bool 반환)
            if(lottos.Contains(win_nums[i]))
            {
                //확정 일치값 +
                accurate++;
            }
        }
        
        // min max 변수할당
        int max = tempNum+accurate;
        int min = accurate;
        
        // 일치값 0인 경우 처리
        
        if(max==0) max++;
        if(min==0) min++;
        
        
        //일치하는 값만큼 순위가 높으므로 7-n 으로 배열의 속성을 지정
        int[] answer = new int[] {7-max,7-min};
        
        
        return answer;
    }
}