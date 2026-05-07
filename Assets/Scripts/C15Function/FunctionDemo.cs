using UnityEngine;

public class FunctionDemo : MonoBehaviour
{
    // i) 함수 만들기(선언, 정의)
    void Hi()
    {
        Debug.Log("안녕하세요");
    }

    // iii) 매개변수(parameter)가 있는 함수 만들기(선언, 정의)
    //매개변수를 통해 들어온 문자열을 출력하는 함수
    void ShowMessage(string message)
    {
        Debug.Log(message);
    }

    // iv) 반환 값이 있는 함수 만들기(선언, 정의)
    //문자열을 반환하는 함수
    string GetString()
    {
        //return 키워드로 (데이터 타입에 맞게) 반환
        return "반환값(Return Value)";
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ii) 반환 값이 없는함수 사용하기, 호출하기, call
        Hi();

        ShowMessage("반갑습니다");
        ShowMessage("또 만나요");

        // v) 반환 값이 있는 함수 사용하기, 호출하기, call
        //반환 값과 같은 데이터 타입의 변수로반환 값을 저장한다
        string reValue = GetString();
        Debug.Log(reValue);
        
    }
}

/*
함수(= Function, 매서드, Method)
- 반복해서 사용하도록 만들어진 하나 이상의 명령문을 포함하고 있는 코드 블록
- 가장 작은 단위의 프로그래밍
- 입력 > 연산 > 출력

== 함수의 종류 ==
- 내장 함수 - C#(.net)에서 제공하는 함수, 유니티에서 제공하는 함수
- 사용자 함수 - 유저(개발자)가 만드는 함수
            매개변수가 없는 함수
            매개변수가 있는 함수
            변환값이 있는 함수

void 함수이름()
{
    //하나 이상의 명령문...
}

void 함수이름(매개변수)
{
    //하나 이상의 명령문...
}

//반환 값
(데이터 타입) 함수이름()
{
    //하나 이상의 명령문...
    .
    .
    .
    return (데이터 타입)변수;
}


*/