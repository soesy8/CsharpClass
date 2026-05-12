using System.Collections;
using UnityEngine;


public class QueueNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Queue 클래스의 인스턴스(객체) 색성
        Queue queue = new Queue();

        // [2] Queue에 데이터 넣기
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Debug.Log(queue.Peek());        // 10

        // [3] Queue에서 데이터 꺼내기  //선입선출
        Debug.Log(queue.Dequeue());     // 10
        Debug.Log(queue.Dequeue());     // 20
        Debug.Log(queue.Dequeue());     // 30

        
    }
}
/*
Queue : FIFO( First In First Out ) , 선입선출 형태로 데이터를 저장, 관리하는 클래스
: 은행, 병원 대기표 / 터널형 창고 데이터 관리
Enqueue() : 큐에 데이터 넣기, 저장
Dequeue() : 큐에서 데이터 꺼내기




*/