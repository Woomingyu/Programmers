using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        
        
        //p를 long으로 변환
        long longP = long.Parse(p);
        
        //t길이에 p 길이만큼 뺀 값 EX) 12456, 356 = 2
        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            //저번에 사용한 문자열 자르기 .Substring()
            long temp = long.Parse(t.Substring(i, p.Length));

            if (temp <= longP)
                answer++;
        }
        return answer;
        
        //다시 공부하고 프로그래머스에 메모★    
    }
}