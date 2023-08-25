using System;//Math.Sqrt를 사용하려면 불러와야함

public class Solution {
    public long solution(long n) {
        
        // Math.Sqrt 제곱근 반환 EX) Math.Sqrt(9) / 결과값 3 Math.Sqrt(16) / 결과값 4
        // n의 제곱근을 가지는 result (long인 이유는 n과 형을 맞춰야 해서)
        long result = (long)Math.Sqrt(n); 
        //result 의 제곱이 n이라면 result+1의 제곱을 리턴 / else -1을 리턴
        return (result*result == n) ? (result+1)*(result+1) : -1;
    }
}