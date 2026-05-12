using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack 클래스의 객체, 인스턴스) 생성
        Stack stack = new Stack();

        //[2] 데이터 입력
        stack.Push("첫 번째");
        stack.Push("두 번째");
        stack.Push("세 번째");

        //[3] 데이터 꺼내기
        Debug.Log(stack.Pop());     //세 번째
        Debug.Log(stack.Pop());     //두 번째
        Debug.Log(stack.Pop());     //첫 번째

        /*try
        { Debug.Log(stack.Pop()); }                 //빈 스택 출력
        catch(System.Exception ex)
        { Debug.Log($"{ex.Message}오류 발생"); }    //"Stack empty.오류 발생"
        finally
        { Debug.Log("오류 미발생"); }*/             //"오류 미발생" 그냥 찍기
    }
}
/*
Stack : LIFO( Last In First Out ), 후입선출 형태로 데이터를 저장, 관리하는 클래스
우물형 데이터, 접시형 데이터
Push() : 스택구조에서 데이터 넣기
Pop() : 스택구조에서 데이터 꺼내기
Overflow : 스택이 가득 찼을 때 발생, 우물이 넘칠 때
Underflow : 스택이 비어있을 때 발생, 우물이 바닥났을 때


Queue : FIFO( First In First Out ), 선입선출 형태로 데이터를 저장, 관리하는 클래스

*/