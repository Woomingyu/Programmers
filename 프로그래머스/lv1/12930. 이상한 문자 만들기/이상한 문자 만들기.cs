using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        //1.s는 한개 이상의 단어'들'로 구성
        //2.각 단어는 하나 이상의 공백 문자로 구분이 '이미 되어 있다.'
        //3.각 단어의 '짝수'번째 알파벳은 대문자, '홀수'번째 알파벳은 소문자로 바꾼 문자열을 리턴 
        //4.문제엔 없지만 입력값은 각 단어의 대문자와 소문자가 랜덤하게 들어온다.(소문자 변형도 필요)
        
        
        
        //지정된 문자에 따라 문자열을 부분 문자열로 잘라주는 메서드 .Split(지정된 문자)
        //또한 .Split(지정된 문자, 제외할 문자) 를 통해 해당 배열에서 제외하고 싶은 문자도 추가할 수 있다.
        string[] temps = s.Split(" ");
        
        //단어 개수만큼 반복
        for(int i = 0; i < temps.Length; i++)
        {
            //각 단어의 길이만큼 반복
            for(int j = 0; j < temps[i].Length; j++)
            {
                //짝수인 0의 경우를 제외
                if(j == 0)
                {
                    //Char.ToUpper == 해당하는 문자를 대문자로 변경(i단어 배열의 j번째 문자)
                    //Char.ToLower 해당 문자열 소문자로 
                    answer += Char.ToUpper(temps[i][j]);
                    //해당 반복에 한하여 종료
                    continue;
                }
                //나머지 홀짝 번째의 단어 구분(0과 다르지 않음) 
                if(j % 2 == 0)
                {
                    answer += Char.ToUpper(temps[i][j]);
                }               
                else
                {
                    answer += Char.ToLower(temps[i][j]);
                }              
            }
            //위의 결과 띄어쓰기가 생략되어 에러가 발생, 각 단어 반복 종료 후 띄어쓰기를 추가
            //배열 -1 번째라면(마지막 단어라면) 해당 과정을 생략(끝부분에 공백이 추가되므로)
            if (i != temps.Length-1)
                {
                    answer += " ";
                }
        }                 
        return answer;
    }
}