using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        
        //기사의 번호 number, 각 기사 번호의 약수의 개수에 해당하는 공격력을 가진 무기가 있다.
        //무기의 공격력은 제한치 limit가 있으며, 약수가 이 수 이상이라면 가질 무기의 공격력을 power로 한다.
        //무기는 공격력 1당 1의 철이 필요하며, 기사 모두의 무기를 만들기 위해 필요한 철을 return해야한다.
        
        int answer = 0;
        
        //기사단원 모두의 무기가 필요하므로 number만큼 반복
        for (int i = 1; i <= number; i++)
        {
            
            //count : 현재 반복에 해당하는 기사의 약수의 개수(무기 공격력)을 저장한다.
            int count = 0;
            
            //j*j가 조건인 이유는, 해당 값의 결과가 약수를 구할 대상보다 큰 경우는
            //이미 약수의 범위에서 벗어나기 때문에, 반복을 최소화하기 위함이다.
            for (int j = 1; j * j <= i; j++)
            {
                //약수인 경우만 탐색
                if (i % j == 0)
                {
                    //1과 자기자신을 제외한 약수를 찾는 조건
                    if (i / j == j)
                    {
                        count++;
                    }
                    //모든 경우에 존재하는 약수인 1과 자기자신(약수가 추가적으로 존재하는 부분은 if에서 관리)
                    else
                    {
                        count += 2;
                    }
                }
            }

            //약수가 제한치를 넘는지 체크
            if (count <= limit)
                answer += count;
            else//제한치를 넘는경우에 추가로 들어갈 값
                answer += power;
        }
        return answer;
    }
}