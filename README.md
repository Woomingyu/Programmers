# 풀이 결과보고 새로 알아낸 것

1.평균 구하기 ==> 배열.Average(); 입력받은 배열값의 평균을 내 주는 메서드

2.약수 구하기 ==> 약수의 정의를 통한 반복의 절반 감소

3.나머지가 1이 되는 수 찾기 ==> 나머지가 1이되는 최소값을 for의 i로 찾아준다. for (int i = 1; ++i < n - 1;)

있으면 정답에 반환, 없으면 주어진 수 -1 후 반환

18.없는 숫자 더하기 ==> using System.Linq와 Sum을 사용한다.  
주어진 1~10을 더한 값을 answer에 넣어주고, 그 후 Sum을 통해 numbers 배열안의 모든값을 더한만큼 answer을 빼준다.


20.가운데 글자 가져오기 ==> 문자열에 .Substring(매개변수1, 매개변수2)의 구조를 가진 메서드는\t
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
