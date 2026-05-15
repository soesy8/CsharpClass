using UnityEngine;

namespace Method
{
    //메서드 축약형
    public class MethodExpression : MonoBehaviour
    {

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Work();
            Hello();
            Debug.Log(DoubleValue(5));
            // 3, 5 => 8
            Debug.Log(SumTwo(3, 5));
        }

        // [1] 메서드 - 기본 형식
        void Work()
        {
            //실행 명령문
            Debug.Log("Work 메서드 실행");
            // . . .
        }

        // [1] 메서드 축약형 - 실행 명령문 1줄
        void Hello() => Debug.Log("Hello");

        // 매개변수를 입력받은 정수 값을 두 배로 반환하는 함수
        int DoubleValue(int value) => value * 2;

        // 매개변수를 입력받은 두 정수의 합을 반환하는 함수 만들기 - 축약형
        int SumTwo(int a, int b) => a + b;


    }
}


/*



*/