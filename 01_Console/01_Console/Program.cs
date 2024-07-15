namespace _01_Console
{
    internal class Program
    {
        enum AgeCategory
        {
            Child = 0,
            Elemetry,
            Middle,
            High,
            Adult
        }


        int Test(int a, int b, float c)
        {
            int result = 10;
            return result;
        }

        // 함수 이름: 다른 함수와 구분하기 위한 것(사람용)
        // 파라메터 : 함수를 실행하는데 필요한 데이터(0개 이상)
        // 리턴타입 : 함수가 종료되었을 때 돌려주는 데이터 타입(void는 리턴값이 없다는 의미)
        // 함수 바디 : 함수가 실행될 때의 실제 코드

        static void PrintMyData(string name, string age, string address)
        {
            Console.WriteLine($"저는 {address}에 사는 {name}({age})입니다.");
        }

        static void Main(string[] args)
        {
            // 7/15--------------------------------------------------------------------------------------
            //Console.WriteLine("저는 고병조입니다. 나이는 43살입니다.");
            //int age = 43;
            //Console.WriteLine("저는 고병조입니다. 나이는 " + age + "살입니다.");   // 절대 비추천
            //// 합칠 때는 이런 방식으로 처리. 쌍따옴표앞에 $붙이고 변수는 {} 사이에 넣기
            //Console.WriteLine($"저는 고병조입니다. 나이는 {age}살입니다.");        

            //string test1 = "테스트";
            //string test2 = "22222";
            //string test3 = test1 + test2;   // 테스트22222
            //Console.WriteLine(test3);
            //test3 = "Hello Hello";
            //Console.WriteLine(test3);

            //// 값타입(Value type) : 스택 메모리에 저장, int, float, bool, 기타 구조체
            //// 참조타입(Reference type) : 힙 메모리에 저장, string, 기타 클래스

            //// null : 비어있다라는 것을 표시하는 단어. 기본적으로 참조타입만 가능
            //// nullable type: 널 가능한 타입. 값타입에 붙여서 사용 가능

            //int? a; // a는 null
            //a = 10; // a는 10

            //string? result = Console.ReadLine();
            //Console.WriteLine(result);

            //// 실습
            //// 1. 이름 입력받기 ( "이름을 입력하세요 : " 라고 출력하고 입력 받기)
            //// 2. 나이 입력받기 ( "나이를 입력하세요 : " 라고 출력하고 입력 받기)
            //// 3. 주소 입력받기 ( "사는 곳을 입력하세요 : " 라고 출력하고 입력 받기)
            //// 4. 이름, 나이, 주소를 한번에 출력하기

            //Console.Write("이름을 입력하세요 : ");
            //string? name = Console.ReadLine();
            //Console.Write("나이를 입력하세요 : ");
            //string? ageString = Console.ReadLine();
            ////int age = int.Parse(ageString);
            //Console.Write("사는 곳을 입력하세요 : ");
            //string? address = Console.ReadLine();

            //PrintMyData(name, ageString, address);
            ////Console.WriteLine($"저는 {address}에 사는 {name}({ageString})입니다.");

            // 제어문(Control Statement)

            //int age;
            //Console.Write("나이를 입력해 주세요 : ");
            //string ageString = Console.ReadLine();
            //age = int.Parse(ageString);

            //// if : () 사이에 있는 조건이 true면 {} 사이에 있는 코드를 실행한다.
            //if(age > 20)
            //{
            //    Console.WriteLine("성인입니다.");
            //}

            ////if(age <= 20) // 비추천. 두번 확인함.
            //if (age < 21)
            //{
            //    Console.WriteLine("미성년자입니다.");
            //}

            //// if-else : () 사이에 있는 조건이 true면 if아래에 있는 {} 사이의 코드를 실행, false면 else 아래에 있는 {} 사이의 코드를 실행
            //if(age > 20)
            //{
            //    Console.WriteLine("성인입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("미성년자입니다.");
            //}

            // 실습
            // 1. 나이를 입력받기
            // 2. 8살 미만이면 "미취학 아동입니다" 출력
            // 3. 13살 미만이면 "초등학생입니다" 출력
            // 4. 16살 미만이면 "중학생입니다" 출력
            // 5. 19살 미만이면 "고등학생입니다" 출력

            //int age = 0;
            //Console.Write("나이를 입력하세요 : ");
            //string ageString = Console.ReadLine();
            //age = int.Parse(ageString);
            //int categoty = 0;       // 매직넘버 : 안쓰는게 좋다.
            //AgeCategory ageCategory;

            //if (age < 8)
            //{
            //    Console.WriteLine("미취학 아동입니다.");
            //    categoty = 0;
            //    ageCategory = AgeCategory.Child;
            //}
            //else if(age < 13)
            //{
            //    Console.WriteLine("초등학생입니다.");
            //    categoty = 1;
            //    ageCategory = AgeCategory.Elemetry;
            //}
            //else if (age < 16)
            //{
            //    Console.WriteLine("중학생입니다.");
            //    categoty = 2;
            //    ageCategory = AgeCategory.Middle;
            //}
            //else if (age < 19)
            //{
            //    Console.WriteLine("고등학생입니다.");
            //    categoty = 3;
            //    ageCategory = AgeCategory.High;
            //}
            //else
            //{
            //    Console.WriteLine("성인입니다.");
            //    categoty = 4;
            //    ageCategory = AgeCategory.Adult;
            //}

            //// switch : () 사이에 있는 값에 따라 다른 코드를 수행하는 조건문
            ////switch(categoty)
            ////{
            ////    case 0:
            ////        Console.WriteLine("미취학 아동은 1000원입니다.");
            ////        break;
            ////    case 1:
            ////        Console.WriteLine("초등학생은 2000원입니다.");
            ////        break;
            ////    case 2:
            ////        Console.WriteLine("중학생은 3000원입니다.");
            ////        break;
            ////    case 3:
            ////        Console.WriteLine("고등학생은 5000원입니다.");
            ////        break;
            ////    case 4:
            ////        Console.WriteLine("성인은 10000원입니다.");
            ////        break;
            ////}

            //switch (ageCategory)
            //{
            //    case AgeCategory.Child:
            //        Console.WriteLine("미취학 아동은 1000원입니다.");
            //        break;
            //    case AgeCategory.Elemetry:
            //        Console.WriteLine("초등학생은 1000원입니다.");
            //        break;
            //    case AgeCategory.Middle:
            //        Console.WriteLine("중학생은 3000원입니다.");
            //        break;
            //    case AgeCategory.High:
            //        Console.WriteLine("고등학생은 5000원입니다.");
            //        break;
            //    case AgeCategory.Adult:
            //        Console.WriteLine("성인은 10000원입니다.");
            //        break;
            //    default:
            //        break;
            //}

            //int point = int.Parse(Console.ReadLine());
            int point;
            if( int.TryParse(Console.ReadLine(), out point) )
            {
                Console.WriteLine("정상 변환");
            }
            else
            {
                Console.WriteLine("변환 실패");
            }

            Console.WriteLine(AgeCategory.Child);

            // 실습
            // 1. 성적용 enum 만들기(A,B,C,D,F)
            // 2. 점수를 입력 받아서 90점 이상이면 A, 80 이상이면 B, 70점 이상이면 C, 60점 이상이면 D, 60점 미만이면 F를 주기





            //// 7/12--------------------------------------------------------------------------------------
            //// Comment : 주석. 코드에 아무런 영향을 주지 않는다. 코드 설명용

            ///*
            // * 여러줄 주석 처리하기
            // */

            ///// 엔터치면 아래줄로 주석으로 만듬
            ///// 

            //// 디버깅용 단축키
            //// F5 : 디버그 모드로 시작. 디버깅 중일 때는 다음 브레이크 포인트까지 진행
            //// F9 : 브레이크 포인트 지정
            //// F10 : 현재 멈춰있는 지점에서 다음 점으로 넘어가기

            //// 편집용 단축키
            //// Ctrl + D : 현재 코드를 한줄 복사해서 붙여넣기
            //// Shift + Del : 현재 줄 지우기
            //// Ctrl + 좌우화살표 : 단어 단위로 이동하기
            //// Ctrl + 위아래화살표 : 커서 위치는 그대로 두고 페이지를 위아래로 움직이기

            //Console.WriteLine("Hello, World! - 고병조");
            //Console.WriteLine("Hello, World 222222222222222222");
            //Console.WriteLine("가가가가");

            //// 변수 : 데이터를 저장해 놓은 곳(메모리에서의 위치)
            //// 함수 : 특정한 기능을 수행하는 코드 덩어리
            //// 클래스 : 특정한 동작을 하는 물체를 표현하기 위해 변수와 함수를 모아 놓은 것

            //// 데이터 타입 : 변수의 종류.
            ////  정수(Integer) : int, 소수점이 없는 숫자(0, 10, -25 등등)
            ////  실수(float) : float, 소수점이 있는 숫자(3.14, 5.2222 등등)
            ////  불리언(boolean) : bool, true나 false만 저장하는 데이터타입
            ////  문자열(string) : string, 글자 여러개를 저장하는 데이터 타입

            //int a = 10; // integer타입으로 변수를 만들고 이름을 a라고 붙이고 a에 10이라는 값을 넣어라
            //a = 2100000000;
            ////a = 4100000000;   // 사이즈를 넘어가면 실행안됨
            ////a = 21.5f;        // 데이터 타입이 다르면 안됨

            //float b = 20.123456111111111111111111111111111111111f;
            //double b2 = 20.123456789123456789123456789;
            //b = 20; // int의 표현범위가 float보다 작기 때문에 가능

            //bool c = true;      // (11 > 5) == true,  (11 < 5) == false, 참 또는 거짓을 저장
            //string d = "hello"; // 문자열, 문자가 여러개 있다.(직접 비교는 최대한 피해야 한다.)
            ////104 101 108 108 111 0

        }
    }
}
