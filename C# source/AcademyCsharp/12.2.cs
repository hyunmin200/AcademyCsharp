using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCsharp
{
    class Program2
    {
        // 전역 변수
        // 함수의 외부에서 선언된 변수로, 어디에서든 접근이 가능하며,
        // 프로그램이 종료되어야만 메모리에서 사라지는 특징을 가집니다.
        int valueable = 10;

        // 정적 변수
        // 지역 변수와 전역 변수의 특성을 동시에 가지는 변수이며, 프로그램이
        // 종료되어야만 메모리에서 사라지는 특징을 가지고 있는 변수입니다.
        static int signal = 0;

        static void Main(string[] args)
        {
            // 값 형식
            #region 값 형식
            {
                // 변수가 갑을 담는 데이터 형식입니다.

                // char, short, int, long, float, double

                // 변수의 명명 규칙
                // 1. 같은 이름의 변수를 사용할 수 없습니다.
                // 2. 변수의 첫번째 단어를 숫자로 시작할 수 없습니다.
                // 3. 변수의 이름에 공백이 존재할 수 없습니다.
                // 4. 변수의 이름에 특수 기호를 사용하려면 _만 가능합니다.
                // 5. 변수의 이름으로 예약어를 사용할 수 없습니다.

                // 지역 변수
                // 지정된 지역에서만 사용할 수 있는 변수입니다.
                // 변수가 선언된 블록 내에서만 유효하며, 블록이 종료되면
                // 메모리에서 사라지는 특징을 가지고 있다.

                int value = 20;
                float count_Down = 10.56f;

                {
                    int value3 = 10;
                }

                value = 10;

                Console.WriteLine("value의 값 : " + value);
                Console.WriteLine("count_Down의 값 : " + count_Down);
                Console.WriteLine("signal의 값 : " + signal);

                // 스택 영역
                // 함수의 호출과 관계되는 지역 변수와 매개변수가
                // 저장되는 영역입니다.
            }
            #endregion

            // 참조 형식
            #region 참조 형식
            // 변수가 값 대신 값이 있는 곳의 위치를 참조하여 저장하는
            // 데이터 형식입니다.

            // 배열
            // 같은 자료형의 변수들로 이루어진 유한 집합입니다.
            int[] array = new int[] { 10, 20, 30, 40, 50 };
            // 배열의 크기를 생략하게 되면 컴파일러가 알아서 배열의 인덱스를 
            // 보고 크기를 자동으로 설정한다.

            Console.WriteLine("\nArray\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("array[{0}]의 값은 : " + array[i], i);
            }

            Console.WriteLine("\nSpcae\n");

            int[] space = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 10 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("space[{0}]의 값은 : " + space[i], i);
            }

            //배열의 크기는 프로그램이 실행되는 동안 변경할 수 없습니다.

            // class, interface, array, enum, object, string

            string name = "HwangHyunMin"; // 12개의 문자
            name = "twowon"; // 6개 문자
            Console.WriteLine("name 변수의 값 : " + name);

            // 힙 영역
            // 사용자가 직접 메모리 공간을 저정하고 해제하는 영역입니다.
            #endregion

            #region 조건문
            // 조건문
            // 어떤 조건이 주어질 때 해당 조건에 따라 동작을 수행하도록 실행
            // 하는 명령문입니다.
            // if(조건문)
            // {
            //     실행할 코드
            // }



            // 관계 연산자
            /*
            // 두 개의 피연산자의 값을 비교하여 그 결과를 true(1) false(0)
            // 이라는 값으로 나타내는 연산자입니다.

            // < -> x > y (x가 y보다 크다면)
            // > -> x < y (x가 y보다 작다면)
            // <= -> x <= y (x가 y보다 작거나 같다면)
            // >= -> x >= y (x가 y보다 크거나 같다면)
            // == -> x == y (x와 y의 값이 같다면)
            // != -> x != y (x와 y의 값이 같지 않다면)

            bool check1 = 10 > 5;
            bool check2 = 10 < 5;
            bool check3 = 10 >= 5;
            bool check4 = 10 <= 5;
            bool check5 = 10 == 5;
            bool check6 = 10 != 5;

            Console.WriteLine(check1);
            Console.WriteLine(check2);
            Console.WriteLine(check3);
            Console.WriteLine(check4);
            Console.WriteLine(check5);
            Console.WriteLine(check6);
            */
            #endregion

            #region if문
            // if 문
            // 어떤 특정한 조건을 비교하여 조건이 맞다면 실행하는 명령문

            // if문에 연결된 모든 조건문의 조건이 맞을 때 가장 위에 있는
            // 조건문만 실행됩니다.
            if (10 == 10)
            {
                Console.WriteLine("a");
            }
            else if (10 == 10)
            {
                Console.WriteLine("b");
            }

            // else if문
            // if문의 조건이 틀릴 때 else if문의 조건이 맞다면 실행되는 명령문 입니다.
            #endregion
            // 반복문이란?
            // 프로그램 내에서 특정한 작업을 반복적으로 수행하는 명령문입니다.

        }
    }
}
