using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 123456789;
        int a = 0;
        
        for(int i = 0; i < absolutes.Length; i++)
        {
            if(signs[i])
            {
                a += absolutes[i];
            }
            else
            {
                a -= absolutes[i];  
            }          
        }
        
        return a;
    }
}