using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long result = 0;
        
        for(int i = 1; i <= count; i++)
        {
            result += (long)price * i; // 현재 price에 i를 곱하고 결과에 더합니다.
        }
        
        if(result<=money)
            return 0;
        else
            return result-money;
    }
}