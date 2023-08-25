
public class Solution {
    public int[] solution(long n) {

        string a=n.ToString(); //입력값 sting 형변환
        int[] answer = new int[a.Length]; // 답안에 a.Lengh만큼의 배열을 생성
        for(int i=0;i<a.Length;i++) // a.Length만큼 반복
        {
            answer[i]=(int)(n%10); //각 배열에 순차적으로 int형변환 n%10 (1의 자리)를 넣어준다.
            n=n/10; //입력값을 10으로 나눠 1의 자리를 날린다.
        }
        return answer;
        
        //자릿수 더하기 응용
        //int[] reverse = Enumerable.Reverse(answer).ToArray();
        //return reverse;
    }
}