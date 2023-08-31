public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        
        
        
        for(int i=0;i<phone_number.Length;i++) // phone_number.Length만큼 반복
        {
                if (i < phone_number.Length-4) //phone_number의 뒷 4자리(끝에 들어감)
                {
                    answer += "*";
                }
                else // phone_number의 앞자리들
                {
                    //answer가 string 형이므로 숫자가 +char1, +char2 ...이런식으로 추가됨
                    answer += phone_number[i]; 
                }
        }
        return answer;
    }
}