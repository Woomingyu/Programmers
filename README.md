# 풀이 결과보고 새로 알아낸 것

1.평균 구하기 ==> 배열.Average(); 입력받은 배열값의 평균을 내 주는 메서드

2.약수 구하기 ==> 약수의 정의를 통한 반복의 절반 감소

3.나머지가 1이 되는 수 찾기 ==> 나머지가 1이되는 최소값을 for의 i로 찾아준다. for (int i = 1; ++i < n - 1;)

있으면 정답에 반환, 없으면 주어진 수 -1 후 반환

18.없는 숫자 더하기 ==> using System.Linq와 Sum을 사용한다.  
주어진 1~10을 더한 값을 answer에 넣어주고, 그 후 Sum을 통해 numbers 배열안의 모든값을 더한만큼 answer을 빼준다.


20.가운데 글자 가져오기 ==> 문자열에 .Substring(매개변수1, 매개변수2)의 구조를 가진 메서드는  
   문자열을 '잘라주는' 기능을 한다. 해당 메서드와 매개변수를 이용해 훨씬 짧고 간단하게 중간 글자를 구할 수있다.  
   (매개변수1 문자열을 자르기 시작할 index값, 매개변수 2는 어느 길이만큼 자를 것인지 의미)


22.내적 ==> 어려워 보이지만 a[0]*b[0]+a[1]*b[1]+......+a[n-1]*b[n-1] 이 식만 기억하면 문제없다.


23.약수의 덧셈과 뺄셈 ==> 이중 반복문을 통해 주어진 반복 실행 & 주어진 조건 실행 & 결과 합산을 나누었다.


24. 문자열 내림차순으로 배치 ==>  
[10. 정수 내림차순]을 참고하였다. 사용한 메서드는 다음과 같다.  
문자열.ToCharArray() & Array.Sort(배열); Array.Reverse(배열)  
그 후  new string(문자 배열) 을 통해 char 배열을 string 변환 후 반환


26. 문자열 다루기 기본(문자열 길이 /문자열에 숫자&문자 섞여있는지 판별) ==>  
foreach (char c in s) 로 문자열을 char[]배열처럼 사용 가능 char[0]에서 char[c] 까지 반복한다. 각 반복은 c == i(for반복문의 구성요소) 로 체크한다.  
if (!char.IsDigit(c)) 위의 foreach문 안에서 해당 조건문을 돌리면 문자열 내부에 숫자 혹은 문자가 섞였는지 판별 가능하다.  
char.IsDigit(char) 각 문자가 0에서9 중 하나인지 판별하는 bool 반환 메서드임 (0~9 : true)


27.행렬의 덧셈 ==> 2차원 배열의 길이를 가져오는법 arr1.GetLength(0) 을 사용하면된다.  
문제 자체는 2차원 배열의 개념만 알고있으면 어렵지 않았다. 2중 for문을 이용해 2차원 배열에서 두 배열의 값을 각각 더해주는 식으로 진행


29.최대공약수와 최소공배수 ==> [재귀함수]를 사용하는 최초 케이스이므로 중요함  
유클리드 호제법 활용(두개의 수가 주어졌을 때 a%b = r , r % r = r2, r2 % r2 = r3..... 하고 나머지가 0이되는 경우가 최대공약수이다.)  
유클리드 호제법을 사용하는 메서드를 따로 생성하고, 파라미터 값을 받은 후, 원하는 값이 나오면 return하고 아닌 경우에 자신을 재참조하는  
재귀함수를 만든다. 재귀적인 함수는 어떻게 만드는데? ==> return gcd(m, n%m); 이처럼 리턴시에 자신을 호출하며, 계산하거나 계산된 반환값을 넣으면 된다.


30.3진법 뒤집기  
일반 10진법 수를 3진법으로 변환하는 방법과, 3진법 수를 10진법으로 변환하는 방법을 알아보았다.  
10진법->3진법 : 각 자릿수에 n%3을 넣은 뒤, n/3을 통해 뒤에 수가 더 있는지 확인, 다음수를 변경한다.  
3진법->10진법 : answer += (int)(list[i] * Math.Pow(3,i)); //3의 거듭제곱을 통해 10진법으로 돌려놓는다.  
나머지 내용은 이전에서 충분히 진행, 반복하였으므로 생략


31.이상한 문자 만들기  
string.Split(temp) 긴 문자열을 특정 단어(temp) 에 따라 구분해주는 메서드이다(stirng[] 배열로 반환), 아무것도 적지 않을 시 공백을 기준으로 함  
또한 string.Split(temp, n)을 통해서 특정 단어를(temp) 통해 구분하고, 문자열에서 '제외' 하고싶은 문자(n)또한 추가 가능하다.  
코드 작성시 최초엔 0의 경우(문자열의 첫번째 문자)를 따로 구분했는데, 제출 후 확인해보니 0인 경우는 구분할 필요 없었다.  
Char.ToUpper(temp) & Char.ToLower(temp) 해당하는 문자(temp)를 각각 대문자, 소문자로 반환해준다.


32.삼총사  
삼중반복문을 통하여 모든 요소를 더해보았다.(각 반복에 i+1, i+2)  
더 좋은 방법이 있는지 궁금했는데 다른사람의 풀이도 비슷했음


33.크기가 작은 부분  
코드보단 문제 해결의 이해해 좀 시간이 걸렸다.  
주요 코드로는 이전에 20.가운데 글자 가져오기에서 사용했던 .Substring()를 사용했다.  
이번엔 .Substring(시작지점, 끝 지점) 까지 입력받은 string을 잘라내는 역할을 수행하였다.  
for (int i = 0; i <= t.Length - p.Length; i++) 반복을 통해 판별할 수 p 보다 t가 얼마나 더 긴지 확인&그만큼 반복  
long temp = long.Parse(t.Substring(i, p.Length)); 반복 내부에서 string 잘라내기를 통해 i번째 에서 p의 길이만큼의 수를 잘라내서 가져옴  
if (temp <= longP) answer++; 크기 판별 후 카운트 상승  


34.최소직사각형(다시 공부)


35.시저 암호  
StringBuilder의 Append [문자열 추가]를 이용해 +연산자를 최대한 줄일 수 있다.  
temp += n%26;  if(temp > 'Z') temp -= 26; 의 과정을 통하여, 알파벳 내부에서만 순환하는 코드를 만들 수 있다.  
temp는 받아온 문자열의 int 배열 변수이다.


36.숫자 문자열과 영단어  
해결 : 스위치 케이스를 쓰면 간단하지만, 다른 방식을 찾아서 써 보았다.     
string Replace (old, new); ==> string, char 모두 사용 가능하다.  
old 문자열을 new 문자열로 바꿔주는 메서드이다.  
문자 => 숫자 변환은 이런식으로 해결했고, 숫자, 문자를 추가로 판별하는것은 TryParse를 통해 해결했다.  
if(int.TryParse(s, out result)) // 여기서 result를 답안으로 반환했음.


37.문자열 내 마음대로 정렬하기 (다시 공부)


38.K번째수 (다시 공부)


39.두 개 뽑아서 더하기
해결 : 배열에 추가되는 값의 길이를 예상할 수 없으므로 리스트를 사용하였다.  
리스트변수.Distinct()를 사용하면, 대상 배열에서 중복값을 제거한다.  
이 경우, 리스트로 다시 반환하고 싶다면 반드시 .ToList(); 해 주어야 하는데, 왜 이미 List 형태인 것을 ToList 해 주는가 하면  
리스트변수.Distinct() 를 사용한 후 결과를 Enumerable<T> 형식으로 반환하므로, 형변환이 필요한 것이다.


40.가장 가까운 같은 글자  
해결 : 우선 각 속성을 저장할 변수  int index = -1; 를 만든다.(뒤의 반복에서 중복이 없는경우 고정값이므로 -1로 선언)  
index는 매 반복 시 초기화 시키고, 내부 반복에선 i - 1에 해당하는 (현재 반복의 바로 이전) j를 통한 반복을 진행  
내부 반복은 j가 0이상인 경우에만 실행하며, 처음엔 -1이르므로 바로 넘어가서 첫 속성[i]에 index == -1을 넣음  
즉 내부 반복에서는 현재의 인덱스[i]와 이전의 인덱스들 모두를 비교하게 됨 : [j]를 0까지 반복하므로  
i와 j의 속성을 비교하여 동일한 경우에만 index에 i-j, 즉 현재 속성 위치와, i보다 작은 인덱스 값의 모든 속성 중 찾아낸 동일한 속성의 거리차이를 계산 후 반환


41.푸드 파이트 대회 (다시 공부)


42.콜라 문제  
조건과 교환비에 따른 콜라 개수까지는 매우 쉬움  
교환 후 내가 보유한 빈 병의 개수에서 조금 막혔으나 풀고보니 간단했음  
n = (n / a) * b + n % a; 교환비에 따른 콜라 개수 +  
n % a 를 통해 원래 가지고 있는 빈 병 개수에서 교환비 나머지 값을 더해줌


43.명예의 전당 (1)
List를 생성하여 명예의 전당 추가와 제거가 용이하도록 만들고,
list의 Length가 3과 같은 경우(명예의 전당이 가득 찬 경우)에만 점수 비교를 진행하도록 했다.
스코어에 따라 continue를 통해 반복을 넘어가는것을 조절하였으며, 새로운 점수가 들어오는 경우 list.Sort 를 통해 내림차순 정렬하였다.


44.2016 (주어진 날짜의 요일 구하기)  
요일을 가지는 string 배열과 각 달의 값을 가지는 int 배열을 선언 후,  
주어진 달의 값을 이용해 반복문 사용 ==> 이전 달의 일 수를 모두 구함  
그 후 주어진 일의 값을 더한 후, %7 하여 요일을 구한 후  
요일 배열에 해당 int값 순번을 요청


45.카드 뭉치  
조건이 좀 헷갈렸다.  
각 카드뭉치에서 조건문을 통해 덱 1과 덱 2의 속성을 goal 속성과 각각 비교해보고,  
일치하는 경우에 동일 사용을 방지하기 위해 변수를 통해 덱 index를 변경하며, 결과를 내보낸다.  


46.과일 장수
각 상자에 들어가는 사과의 int index를 선언해준다. (이 때 주어지는 박스에 들어갈 사과의 수는 1부터 시작하는 정수이므로 -1 해준다.)
낮은 점수 변수를 따로 선언 할 필요 없이 정렬 Array.Sort / Array.Reverse 를 사용하여 가장 낮을 값을 구하고,
박스가 추가적으로 생긴 경우를 대비해서 index += 박스에 들어가는 사과 수를 해주어 앞 박스의 낮은 점수의 값을 배제한다.


47.모의고사  
2차원 배열과 이중반복문을 사용하였다.  
특이사항으로는 정답과 학생의 답안 길이가 맞지 않는 경우를 위해 i%students[j].Length를 진행 후 학생의 점수에 반영했다.  
if(students[j][i%students[j].Length] == answers[i])


48.소수 만들기
3중 for문을 이용해 주어진 배열에서 나오는 모든 경우의 수를 계산하였다.(계산하는 수가 3개이므로)  
        for(int i=0; i<nums.Length-2; i++)  
            for(int j=i+1; j<nums.Length-1; j++)  
                for(int k=j+1; k<nums.Length; k++)  


49.덧칠하기  
반복문과 간단한 식을 통해서 구현하는 방법을 알 수 있었다.  
num = (section[i] + m) - 1; // 칠해야 하는 끝부분의 값을 구해주는 식을 통해  
반복->조건(조건 충족 시 계산식 -> 결과값 수정) 을 통해 문제 해결이 진행되었다.


50.기사단원의 무기
여전히 수학을 너무 못한다. 약수 판별 문제였다.  
핵심 부분은 약수를 찾아 걸러주는 부분이였다.  
for (int j = 1; j * j <= i; j++) 에서 j*j를 조건으로 반복을 최소화 한다.(이보다 큰 값은 약수에서 벗어남)  
약수 탐색은 익숙한 i % j == 0 으로 진행하고, 약수의 개수를 판별하는 방법으로  
i / j == j로 1과 자기자신을 제외한 모든 약수를 판별하고, 이 외의 경우는 1과 자기 자신 뿐이므로 else에서 2를 더해준다.  
쉬운 문제였는데 팀 프로젝트 진행하다 하려니까 풀이를 봐도 코드 뜯는데 좀 걸린게 웃기다.  


51.로또의 최고 순위와 최저 순위  
진짜 쉬운 문제였는데 헷갈렸다. 매주 뇌가 리셋되는듯  
이번 문제의 핵심은 using System.Linq; 를 통한 array.Contains(@) 사용이였다.  
나는 string에서만 Contains를 사용 가능한 줄 알았는데 아니였다.  
생각해보니 string도 엄밀하게 따지면 배열이니 같은 거였네  
좀 고민이 있었던 주어진 배열과 일치하는 수 탐색은 if(lottos.Contains(win_nums[i])) 로 해결되었다.  
또한 일치값 0인 경우를 고려해야 했는데, 각 변수(min,max) 는 개별적으로 처리되므로 각각 예외처리를 해주어야 했다.  
