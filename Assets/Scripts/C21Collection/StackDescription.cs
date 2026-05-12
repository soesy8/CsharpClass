using System.Collections;
using UnityEngine;

public class StackDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Stack 인스턴스 만들기
        Stack stack = new Stack();

        // [2] 데이터 넣기
        stack.Push("대한민국");
        stack.Push("경기도");
        stack.Push("수원");

        // [3] Peek() : 제일 상단(마지막에 넣은) 데이터를 반환
        //     Count : 
        Debug.Log($"{stack.Peek()}, {stack.Count}");    //수원 출력

        // [4] 상단 데이터 꺼내기 - 수원
        stack.Pop();

        // [5] Peek - 경기도 출력
        Debug.Log($"{stack.Peek()}, {stack.Count}");

        // [6] pop - 경기도 꺼내기
        stack.Pop();

        // [7] peek - 대한민국 출력
        Debug.Log($"{stack.Peek()}, {stack.Count}");

        // [8] pop - 대한민국 꺼내기
        stack.Pop();

        if(stack.Count > 0)     //stack.Count == 0
        {
            Debug.Log($"{stack.Peek()}, {stack.Count}");
        }

        // [9] clear : 스택 비우기
        stack.Clear();
        Debug.Log($"{stack.Count}");    //stack.Count == 0


    }
}

/*


*/