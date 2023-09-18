using System;

public class Solution {
    public int solution(string s) {
        
        int result;
        int answer = 0;
        //1.의미가있는 문자와 숫자가 섞이거나, 숫자만 있는 string s 가 주어짐
        //2.의미가 있는 문자는 특정한 수를 나타냄
        //3.숫자의 경우는 그대로 int로 보내면 됨, 하지만 문자에는 수정이 필요함
        //4.문자에 따른 수를 판별하는것이 주요 과제
        //해결 : 스위치 케이스를 쓰면 간단하지만, 다른 방식을 찾아서 써 보았다.        
        //string Replace (old, new); // string, char 모두 사용 가능하다.
        //old 문자열을 new 문자열로 바꿔주는 메서드이다.
        s = s.Replace("zero", "0");
        s = s.Replace("one", "1");
        s = s.Replace("two", "2");
        s = s.Replace("three", "3");
        s = s.Replace("four", "4");
        s = s.Replace("five", "5");
        s = s.Replace("six", "6");
        s = s.Replace("seven", "7");
        s = s.Replace("eight", "8");
        s = s.Replace("nine", "9");

        //변환 후 해당 문자열이 숫자로 반환 가능하다면
        //out을 answer에 넣어준다
        if(int.TryParse(s, out result))
            answer = result; 
        
        return answer;                 
    }
}    