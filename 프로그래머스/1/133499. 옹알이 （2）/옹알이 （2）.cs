using System;

public class Solution {
    public int solution(string[] babbling) {
        
        //주어진 값 : 문자열 Array
        //필요 과정 : 주어진 값 만큼의 반복 -> 정해진 단어 만큼의 반복
        //반복 내에서
        int answer = 0;         
        string[] talk = new string[] { "aya", "ye", "woo", "ma" };
        
        for (int i = 0; i < babbling.Length; i++)
            {
                for (int j = 0; j < talk.Length; j++)
                {
                    //str ==> 연속으로 중복된 단어를 나타냄 
                    string str = talk[j] + talk[j];
                    //지정된 문자(중복)을 Replace를 통해 공백으로 반환
                    babbling[i] = babbling[i].Replace(str, "@").Replace(talk[j], " ");
                }
                //지정된 문자열에서 모든 공백을 제거 후 문자열 길이기 1 미만인 경우에만
                if (babbling[i].Trim().Length < 1)
                    answer++; //반환값 +1
            }
        
        return answer;        
    }
}

//나중에 다시 공부★