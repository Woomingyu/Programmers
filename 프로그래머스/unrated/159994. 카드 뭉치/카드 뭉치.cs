using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        
        //1.영어 단어가 적힌 두개의 배열 존재
        //2.두 개의 카드 뭉치 중 하나에서 순서대로 한 장씩 사용(중복 사용 불가)
        //3.카드는 반드시 사용하며, 카드 뭉치의 순서는 바꿀 수 없음
        //4.요구하는 단어 배열 goal이 존재함, 
        //배열에서 순서대로 뽑아온 값으로 goal을 만들 수 있을경우 yes 아닌경우 no를 반환함
        
        //기본값 Yes
        string answer = "Yes";
        
        //각 덱에서 뽑은 카드를 뜻하는 변수
        int index1 = 0;
        int index2 = 0;
        
        //목표 문자열의 단어 개수만큼 반복
        for(int i = 0; i < goal.Length; i++)
        {
            //index1가 1번덱의 길이보다 작고, goal[i]의 속성값이 1번덱 에서 뽑은 카드와 일치하는 경우
            if(index1 < cards1.Length && goal[i] == cards1[index1])
            {
                //index1변수를 1씩 올려주고, 다음 반복으로 넘어감
                index1++;
                continue;
            }
            
            //위 조건을 만족하지 못했을 경우, 덱 2로 넘어가서 일치하는지 확인
            else if(index2 < cards2.Length && goal[i] == cards2[index2])
            {
                index2++;
                continue;
            }
            else
            {
                return "No";
            }         
        }
        
        //카드의 순서를 바꿀 수 없으니, 덱1, 2에 일치하는 단어가 모두 있어도, 순서가 맞지 않으면 소용없다.
        //덱 1 ~ 2까지 순서대로 goal 배열에 값을 넣을 수 있는지 검증한다.
        //일치하는 경우 중복 카드 사용 방지를 위해 각 index 변수의 값을 1씩 올려주고 반복을 넘긴다.
        //해당 사항이 없는경우 즉시 NO를 리턴한다.
        
        return answer;
    }
}