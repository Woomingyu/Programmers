public class Solution {
    public bool solution(string s) {
        
        //1. 문자열 길이가 4 or 6인지 확인
        //2. 문자가 하나라도 있으면 false 반환
        //3. 전부 숫자라면 true 반환
        //4. 마지막으로 길이가 4 or 6이 아닌경우 false반환
        
        
        if (s.Length == 4 || s.Length == 6) // 1
        {
            foreach (char c in s) //배열용 반복문 char c 변수 생성 -> 문자열 s의 각 문자를 c번째 자리에 넣는다.
            {
                if (!char.IsDigit(c)) // char.IsDigit(char) 각 문자가 0~9인지 판별하는 bool 반환 메서드
                {
                    return false; // 2
                }
            }
            return true; // 3
        }
        else
        {
            return false; // 4
        }
        
    }
}