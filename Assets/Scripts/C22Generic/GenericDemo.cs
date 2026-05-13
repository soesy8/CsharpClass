using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Stack<T> 클래스 인스턴스 생성 : 문자열 전용
        //Stack stack = new Stack();        //collection stack
        /* Stack<string> stack = new Stack<string>();      //generic stack

         // [2] 데이터 넣기
         stack.Push("Ten");
         stack.Push("10");

         // [3] 데이터 꺼내기
         Debug.Log(stack.Pop());
         Debug.Log(stack.Pop());*/

        // [1] 컬렉션
        Stack st1 = new Stack();
        st1.Push(1234);
        int num1 = (int)st1.Pop();      //object 형식으로 꺼내지기 때문에 type 변환 필요
        Debug.Log(num1);

        // [2] Generic 사용
        Stack<int> st2 = new Stack<int>();
        st2.Push(4567);
        int num2 = st2.Pop();           //type 변환 불필요
        Debug.Log(num2);

        // [3] Generic Class의 장점
        //형식의 안정성
        Stack o = new Stack();
        o.Push(9781);
        o.Push("Hello");
        Debug.Log(o.Pop());
        Debug.Log(o.Pop());

        //성능, 최적화
        o.Push(1234);   //1234(값 형식) -> object형에 저장 : 박싱(boxing)
        int num3 = (int)o.Pop();    //object형 -> num3(값 형식) : 언박싱 (unboxing)
        Debug.Log(o.Pop());


        Stack<int> i = new Stack<int>();
        i.Push(1);
        //i.Push("ONE");    에러
        Debug.Log(i.Pop());


    }
}

/*
클래스 ( Class ) : 하나의 이름으로 서로 다른 형식의 데이터들과 함수들을 묶어 관리하는 데이터 구조
제네릭 클래스 ( Generic Class ) : 형식 매개 변수 T 에 지정한 데이터 형식으로 클래스의 멤버의 성질을
결정하는 클래스 / Cup<T> 컵오브티, 전용컵



*/