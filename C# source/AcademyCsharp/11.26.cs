using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCsharp
{
    // 주석
    // 주석은 컴퓨터 입장에서 문법적인 오류들 생성하지 않고,
    // 설명문을 적어줄 수 있는 기능입니다.

    // Main 함수에 넣어주지 않는다면 실행이 되지 않는다.

    //Main() 함수 <- 프로그램이 시작되는 진입점입니다.
    //{
    //  전투 시스템 <- Main 함수 안 쪽에 넣어주셔야 합니다.
    //
    //}

    // 주석을 하게 되면 실행이 되지 않는다.
    internal class Class1
    {
        #region 변수
                //자료형이란?
                //변수에 값을 저장하기 이전에 정수인지, 실수인지, 문자인지
                // 미리 알려주는 명령어 이다.

                // 변수란?
                // 어떤 공간에 어떤 값을 저장하기 위한 이름을 가진 공간입니다.

                // ; : 하나의 문단을 끝내는 기호입니다.
                //char a = 'a';
                //string b = "안녕하세요";
                //int health = 3;

                //unsigned 사용
                //ushort value = 50000;
                //float attack = 50.5f;

                //Console.WriteLine : 출력해주는 함수이다.
                //Console.WriteLine("Hello, World");
                //Console.WriteLine("C#");

                //변수에 있는 값을 출력할 떄는 ""를 하지 않아도 됩니다.
                //Console.WriteLine("a의 값 : " + a);
                //Console.WriteLine("b의 값 : " + b);
                //Console.WriteLine("health의 값 : " + health);
                //Console.WriteLine("attack의 값 : " + attack);
                //Console.WriteLine(health + attack);
    #endregion

        #region 상수
    // const int a = 12345;
    // 상수는 컴파일 시점에 현재 메모리에 있는 값이 고정되기 때문에 값을 바꿀 수 없습니다.
    // a = 1;

    // 리터럴 상수
    // 메모리 공간을 가지고 있지 않은 상수

    // 심볼릭 상수
    // 메모리 공간을 가지고 있는 상수

    #endregion
    }
}
