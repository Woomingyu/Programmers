public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min;
        int max;
        
        //최대공약수
        min = gcd(n, m);
        //최소공배수 두수의 곱 / 최대 공약수
        max = (n * m) / min;
        
        answer[0] = min;
        answer[1] = max;
        return answer;
    }
    public int gcd(int n, int m)
    {
        //두 수 n, m 이 있을 때 어느 한 수가 0이 될 때 까지
        //gcd(m, n%m) 의 재귀함수 반복
        if(m==0) return n;
        
        //여기서 재귀
        //min에서 호출->파라미터값 판별(m이 0인 경우만 n을 반환)
        //그 외의 경우 자신을 재참조 n에 m의 값을 넣고, n%m한다.
        //n%m이 0이 될때까지 계속해서 반복
        else return gcd(m, n%m);
    }
}