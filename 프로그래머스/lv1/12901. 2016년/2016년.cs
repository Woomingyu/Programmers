public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        
        //1.1월 1일이 금요일부터 시작함
        //2.요일 이름을 나타내는 배열 필요
        
        
        string[] day = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        //1~12월 각각의 일 수
        int[] days = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        int totalDays = 0;
        
        //a월의 -1만큼 반복 (해당 월은 b로 계산하므로)
        for(int i=0; i<a-1; i++)
        {
            //각 월의 일 수 만큼 totalDays에 더해줌
            totalDays += days[i];
        }
        //이전 달의 모든 일 수 + 해당 달의 일 수에 -1을 뺌 [배열 크기 오버됨]
        totalDays += b -1;
        
        //총 일수 % 7 의 나머지로 해당 요일 구해서 리턴
        answer = day[totalDays % 7];
        return answer;
    }
}