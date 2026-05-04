using UnityEngine;

public class DoWhileDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;  //초기식

        do  //일단 실행
        {
            //반복 실행문
            Debug.Log("안녕하세요");
            
            //증감식
            i++;
        } while (i < 3);    //조건식

    }
}

/*
== do while
do
{
    //반복 실행문

} while(조건식)

//무조건 먼저 반복 실행문을 실행
//조건식이 참(true)이면 반복문을 실행하고
//조건식이 거짓(false)이면 while문을 종료한다

*/