using System;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        //두 정수 X,Y의 임의의 자리에서 공통으로 나타나는 정수들을 이용하여 (순서 상관X)
        //'만들 수' 있는 '가장 큰' 정수 -> 두 수의 짝꿍
        //짝꿍이 없으면? -> 짝꿍은 -1 || 짝꿍이 0으로만 구성되어 있다면? -> 0
        
        //1.수를 나타내는 문자열 두가지에서 같은 정수 찾기
        //2.도출된 같은 수들을 내림차순 배치하기
        //3.같은 수가 없는경우 -1을 반환하고, 결과에 0 뿐이라면 0을 반환
        //4.리턴값은 문자열
        
        string answer = "";
        
        //각 문자열의 0~9의 등장횟수를 나타내는 변수들
        int[] XArray = new int[10];
        int[] YArray = new int[10];

        //X문자열 전체를 탐색 -> XArray 배열에 X문자열의 각 수를 입력
        for (int i = 0; i < X.Length; i++)
        {
            XArray[int.Parse(X[i].ToString())]++;
            //XArray[X[i] - '0']++; << 생각해본 코드 : 굳이 정수 문자열인데 두번 형변환이 필요한가?
            //문자 0의 아스키 코드값 : 48 ==> 뺀 결과는 해당 숫자의 정수값 : 0~9가 됨
        }
        //Y문자열 전체를 탐색 -> YArray 배열에 Y문자열의 각 수를 입력
        for (int i = 0; i < Y.Length; i++)
        {
            YArray[int.Parse(Y[i].ToString())]++;
        }

        //0~9까지의 수를 탐색 : 역순탐색 이유 => 내림차순 재배치 안해도됨
        for (int i = 9; i >= 0; i--)
        {
            //두 배열의 해당 순번 값 중 하나라도 0이라면-> 다음 반복으로
            if (XArray[i] == 0 || YArray[i] == 0)
                continue;

            // min변수 선언 -> Math.Min(두 수 중에서 더 적은 수 반환 x[i],y[i]
            // : 중복되는 수가 여러개일 경우->그 수를 더 적게가진쪽을 반환
            int min = Math.Min(XArray[i], YArray[i]);

            // string.Concat((문자열에 추가)Enumerable.Repeat(i라는 데이터를 min만큼 반복하여 생성))
            // : 위 min변수와 연계하여 공통되는 수를 입력함
            answer += string.Concat(Enumerable.Repeat(i, min));
        }

        //공통되는 수 없음
        if (answer.Length == 0)
            answer = "-1";
        //공통되는 수 0 뿐(0은 위에서 다 컷했으므로 기본값 0을 받아오게 됨)
        else if (answer[0] == '0')
            answer = "0";
        
        
        return answer;
    }
}