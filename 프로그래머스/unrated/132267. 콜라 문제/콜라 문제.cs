using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        
        //1. a : 빈 병과 콜라 b개의 교환비 / n : 가져갈 빈 병
        //2. 보유중인 빈 병이 a 개 '미만' 이면 빈 병을 더 받을 수 없다. 
        
        //보유한 빈병이 a개 '미만' 인 경우 반복 종료
        while(n > a - 1)
        {
            //(가져간 수 / 교환 비율) * 교환 해주는 콜라의 개수
            answer += (n / a) * b;
            //교환 후 현재 보유 빈병의 개수 수정(가져가서 마신 콜라의 빈병도 포함)
            //(n / a) * b 로 교환받은 콜라(빈 병의 수) + n % a 로 교환받지 못한 빈 병의 수
            //위 공식을 통해 교환 후 새로운 나의 빈 병 개수를 구함
            n = (n / a) * b + n % a;
        }
        
        return answer;
    }
}