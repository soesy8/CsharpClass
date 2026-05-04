using UnityEngine;

public class ForDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //안녕하세요를 3번 출력하는 프로그램 구현
        //for(초기식; 조건식; 증감식)
        for(int i = 0; i < 3; i++)
        {
            //반복 실행문 - 안녕하세요 출력
            Debug.Log("안녕하세요");
        }
    }
}

/*
제어문 : 순차문, 조건문(if, switch), 반복문(for, while, do-while, ...)

== for
for(초기식; 조건식; 증감식)
{
    //반복 실행문
}

초기식 -> 조건식 판별(참) -> 반복 명령문 실행 -> 증감식 -> 조건식 판별(참) -> 반복 명령문 실행 ... 반복
-> 조건식 판별(거짓) -> for문 종료

//초기식 : 조건식에서사용하는 변수의 초기값 설정(초기화) 
//조건식 : 조건식을 참, 거짓으로 판별, 참이면 반복 실행문 실행, 거짓이면 for문 탈출
//증감식 : 조건식의 변수를 다시 연산해주는 식, 반복문을 실행할 때마다 실행한 직후에 실행

for(int i = 0; i < 5; i++)
{
    Debug.Log(i);
}

*/