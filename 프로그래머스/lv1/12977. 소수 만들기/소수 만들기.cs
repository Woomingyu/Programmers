using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        
        
        //항상 3개의 수를 더해야 하므로 3중 for문을 사용(모든 경우의 수 체크 가능)
        for(int i=0; i<nums.Length-2; i++)
        {
            for(int j=i+1; j<nums.Length-1; j++)
            {
                for(int k=j+1; k<nums.Length; k++)
                {
                    //각  nums의 요소를 더해줌(순번대로, 반복에 따라 한칸씩 뒤로 밀림)
                    int n = nums[i] + nums[j] + nums[k];               
                    int count=0;
                    
                    //2에서 합산값까지 반복하여 나누었을 때 나머지가 0이면 count 더함.
                    for(int t=2; t<=n; t++)
                    {
                        if(n%t==0) count++;
                    }
                    //계산 결과가 1이라면 소수임(자기자신만 계산됨/1은 제외함)
                    if(count==1) answer++;
                }
            }
        }
        return answer;
    }
}