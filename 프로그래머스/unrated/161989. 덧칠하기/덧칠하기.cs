using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        //1.전체 범위, 구역 개수는 둘다 n을 사용
        //2.m은 한번에 포함할 수 있는 구역을 의미함
        //3.section은 반드시 칠해야하는 영역을 뜻함.
        
        int answer = 0;
        
        //현재 색칠한 부분의 끝 (최초 0)
        int num = 0;
        
        //n이하의 수를 속성으로 가지는 section 배열만큼 반복
        for(int i = 0; i < section.Length; i++)
        {
            //칠해야 하는 부분의 시작지점이 현재 칠한 지점보다 큰 경우(위치 수정이 필요)
            //반대의 경우는 당연히 이미 칠해져있다고 본다.
            if(section[i] > num)
            {
                //칠한 부분의 끝지점 수정 =>
                //칠해야 하는 부분 + 롤러의 길이 -1(값이 실제 배열보다 1크므로 -1해준다)
                num = (section[i] + m) - 1;
                
                //칠한 횟수 +
                answer++;
            }
        }
        return answer;
    }
}