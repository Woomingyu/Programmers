using System;

public class Solution {
    public int solution(int k, int m, int[] score) {       
        //1.사과의 개수와 점수를 포함하는 배열 score, 사과의 최대 점수 k, 한 박스에 들어가는 최대 사과개수 m
        //2.score 배열의 사과 점수는 1이상 k이하이다.
        //3.한 박스에는 최대 사과 개수를 다 채워서 넣어야 하며, 주어진 사과가 박스에 들어가고 남는 경우,
        //한 박스를 더 만들 수 있는지 판별한다.
        //4.그 후 박스별로 상자의 가격(최저 사과 점수*사과 개수) 계산을 끝내고, 모든 상자의 값을 더한다.
        int answer = 0;
        
        //각 상자의 index는 0부터 시작하므로 -1 해준다.(사과 개수는 1부터 시작하는 정수로 주어지므로)
        int index = m - 1;
        
        //주어진 사과-오름차순 정렬
        Array.Sort(score);
        //주어진 사과-내림차순 정렬
        Array.Reverse(score);
        
        //(주어진 사과의 개수 / 박스에 들어가는 사과의 수) 만큼 반복
        for(int i = 0; i < score.Length / m; i++)
        {
            //배열에서 가장 작은 수 * 박스에 들어가는 상자의 수 (해당 값을 결과에 더해줌)
            //한 박스를 초과하여 만들 수 있는 경우에 값을 더 할 수 있다.
            //반복될 경우를 대비하여 index에 m만큼 값을 더한다.(앞의 박스에 담은 낮은 스코어를 배제하기 위해)
            answer += score[index] * m;
            index += m;
        }
        
        return answer;
    }
}