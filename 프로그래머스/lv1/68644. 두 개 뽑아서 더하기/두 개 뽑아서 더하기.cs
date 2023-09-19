using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        
        
        //리스트를 사용하는것이 핵심
        List<int> tempList = new List<int>();
        int num1 = 0;
        int num2 = 0;

        // 배열 안 서로 다른 수 더하기
        for(int i = 0; i < numbers.Length; ++i) 
        {
            for(int j = i+1; j < numbers.Length; ++j) 
            {
                //i와 i+i인 j번째 배열의 값을 각각 더한 후, 배열에 추가한다.
                num1 = numbers[i];
                num2 = numbers[j];
                tempList.Add(num1 + num2);
            }
        }

        // 중복값 제거 리스트변수.Distinct()를 사용하면, 해당 배열에서 중복값을 제거한다.
        // 이미 List인데 왜 ToList를 해주는지 의문이였는데,
        // 리스트.Distinct()로 중복요소를 제거한 경우 IEnumerable<T> 형식을 반환하므로, List로 형변환이 필요하다.
        tempList = tempList.Distinct().ToList();

        // List를 Array로 변환 후 Sort 오름채순 배열을 통해 answer로 반환.
        answer = tempList.ToArray();
        Array.Sort(answer);

        return answer;
    }
}