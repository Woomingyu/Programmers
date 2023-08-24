public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        answer[0] = x;
        
        for(int i = 1; i < n; i++)
        {
            answer[i] = answer[i-1] + x; // 10000000x1000
        }
        
        return answer; //아마 answer i번째가 int의 범위를 벗어나서 그런듯? 어딘가를 long으로 바꿔야 할듯 (킵)
        //long temp라는 새로운 변수를 만들어 거기에 x + (x * i)의 값을 할당할것인가
        //아니면 그냥 파라미터 x값을 int -> long으로 교체?
    }
}