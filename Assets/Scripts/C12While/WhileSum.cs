using UnityEngine;

public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //while문을 이용해서 1부터 100까지의 합을 구하는 프로그램 구현
        int i = 1;  //초기식
        int n = 100;    //반복 횟수
        int sum = 0;    //합

        while(i <= n)   //조건식
        {
            if (i % 2 == 0)
            {
                sum = sum + i;  // sum = 0+1 > sum = 1+1 > ... sum = 4950 + 100   
            }
            i++;    //증감식
        }

        Debug.Log($"1부터 {n}까지의 합은 {sum}");    //출력
    }
}

