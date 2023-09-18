using System.Linq; //쿼리를 지원하는 클래스 및 인터페이스를 제공

public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[] {};
        
        //1.문자열의 배열과, 문자열내의 '특정 순서'의 문자를 지정하는 int 값을 받는다.
        //2.지정된 문자의 알파벳 순서에따라 배열을 오름차순으로 재정렬한다.
        //3.지정된 문자가 같은경우, 해당 문자열들은 사전순으로 정렬한다.     
        
        
        //strings.OrderBy(x => x) 문자열 배열을 사전식으로 정렬 : 어떻게 이렇게 되는가?
        //1번 : OrderBy는 파라미터값을 사전식으로 정렬해준다.
        
        //2번 : (x => x) : 람다식이며, x는 strings(받아온 매개변수)를 뜻하고, 
        //=>는 몸체와 매개변수 strings를 분리하는 연산자,
        //마지막으로 뒤의 x(몸체)는 수행할 코드, 또는 식이다. 여기서는 그대로 반환하는 경우이기에 x를 그대로 썼다.
        
        //위의 과정으로 strings는 사전식에 따른 배열로 반환되었다.
        
        //3번 : 위의 과정을 거친 IEnumerable<T> 형태의 strings를 다시 재배치하는데, 이번에도 람다식을 사용한다.
        //(x => x[n]) : 이번엔 몸체로 x[n]이 들어갔다. 이는 받아온 x를 x[n]번째를 연산자로 지정하여 배치하겠다는 뜻이다.
        //[현재 x는 모든 strings의 모든 배열을 포함하고 있으므로, x[n]은 각 속성 내부의 순서를 의미한다.]
        
        //현재 strings는 IEnumerable<T> 형태를 취하고 있으므로, 다시 배열 형태로 바꿔준다.
        //IEnumerable = 반복자를 돌릴 수 있는 형태.
        //
        
        
        //OrderBy(람다를 사용했기 때문에 이름이 없다.)
        //다시공부★        
        return answer = strings.OrderBy(x => x).OrderBy(x => x[n]).ToArray();
    }
}