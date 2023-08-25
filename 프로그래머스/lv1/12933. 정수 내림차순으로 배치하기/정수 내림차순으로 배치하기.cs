using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        //문자열이 문자의 나열이므로 n.ToString().ToCharArray(); 형식이 가능함
        char[] input = n.ToString().ToCharArray();
        
        //배열(input)을 오름차순으로 정렬(기본정렬) .Sort
        Array.Sort(input);
        
        //기존 배열 순서를 역순으로 재배치 .Reverse
        Array.Reverse(input);
                
        //순서 : new string으로 input char 배열을 다시 String 형식으로 바꿔줌 ->
        //String 형식을 다시 Convert.ToInt64로 long 형으로 바꿔줌, 그 후 answer에 넣어 반환
        //ToInt32 : int || ToInt64 :long
        return answer = Convert.ToInt64(new string(input));
    }
}