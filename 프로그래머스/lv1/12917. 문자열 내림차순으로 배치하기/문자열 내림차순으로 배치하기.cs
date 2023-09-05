using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        char[] temp = s.ToCharArray(); 
        
        //오름차순 정렬 후 내림차순 정렬
        Array.Sort(temp);
        Array.Reverse(temp);
        
        answer = new string(temp);
        
        return answer;
    }
}