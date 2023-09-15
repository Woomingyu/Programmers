using System.Text;

public class Solution {
    public string solution(string s, int n) {       
        //1.모든 알파벳이 있어야한다. 알파벳은 총 26개이다.
        //2.받은 문자열을 1칸 밀면 뒤의 속성을 받아 tale에 넣고, head를 지운다.
        //3. 대, 소문자, 공백이 속성에 포함된다.
        
        
        //StringBuilder를 통한 메모리 절약 (모든 알파벳을 순회하면서 체크하므로)
        StringBuilder answer = new StringBuilder();
        
        //i == -1부터 시작함/ 이유 : 조건 체크 시 i에 반복만큼 더한 후 체크 할 것이므로
        for(int i = -1; ++i < s.Length;)
        {
            //현재 문자의 위치 저장용 ex)BC
            int temp = s[i];
            
            //공백 체크
            if(s[i] == ' ')
            {
                //StringBuilder를 이용해 + 연산자 없이 " "추가
                answer.Append(" ");
                //아래 과정 생략 후 다음 반복으로(다음 문자로)
                continue;
            }
            
            //소문자 판별
            //a~z까지의 알파벳은 이런식으로 하면 알아서 조건을 만들 수 있었다.
            if(temp >= 'a' && temp <= 'z')
            {
                //★★★★★시저 암호 방식으로 n만큼 오른쪽으로 미는 핵심 코드
                //temp의 위치에 따라(만약 z라면? 뒤의 값에 나머지가 남는 순간 아래 조건을 통해 a부터 시작될 것)
                temp += n%26;
                
                //밀어낸 문자가 z(26)를 넘어가는 경우 다시 a부터 시작하도록 한다. 
                //temp의 속성은 결국 알파벳만을 포함할 수 밖에 없으므로
                //아무리 더하거나 빼도 0~25를 벗어날 수 없다.
                if(temp > 'z')
                    temp -= 26;
            }
            
            //대문자 판별(대문자 제외하면 위와 동일한 작용을 함)
            if(temp >= 'A' && temp <= 'Z')
            {            
                temp += n%26;
                
                if(temp > 'Z') 
                    temp -= 26;
            }
            
            //변경된 char(문자)를 answer에 추가
            answer.Append((char)temp);
        }
        
        
        //ToString 하는 이유? : 현재 우리가 원하는 결과값은 StringBuilder 내부 버퍼에 임시로 저장되어 있다.
        //결과값을 사용하고 싶다면 실체가 없던 내부 버퍼값을 ToString 호출을 통해 실제 문자열을 만들어 줘야한다.
        return answer.ToString();
    }
}