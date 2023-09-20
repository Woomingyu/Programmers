using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string temp = "";
        
        //food의 길이만큼 반복
        for(int i = 1; i < food.Length; i++)
        {
            for(int j = 0; j < food[i] / 2; j++)
            {
                answer += i.ToString();
            }
        }
        temp = String.Concat(answer.Reverse());
        answer += "0" + temp;
        return answer;
        
        //나중에 다시 풀이★
    }
}