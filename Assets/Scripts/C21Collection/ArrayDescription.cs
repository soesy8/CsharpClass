using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//컬렉션 (Collection) : 배열처럼 관련 객체의 그룹을 만들고 관리하는 데이터 구조들을 의미함
// : 배열, 리스트, 딕셔너리, ...

public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 배열 선언 후 초기화
        int[] arr = { 3, 2, 1, 4, 5 };

        //배열 사용하기
        for(int i =0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("========================");

        //정렬(Sort) - 오름차순 1, 2, 3, 4, 5 / 내림차순 5, 4, 3, 2, 1
        System.Array.Sort(arr);
        
        //배열 출력하기
        foreach (int i in arr)
        {
            Debug.Log(i);
        }

        Debug.Log("========================");

        //배열의 역순
        System.Array.Reverse(arr);

        foreach(int i in arr)
        {
            Debug.Log(i);
        }




    }
}

/*
foreach 반복문 - 컬렉션을 가져와서 컬렉션 길이만큼 반복시킨다

//컬렉션 변수의 길이 만큼 반복하며 첫 번째 방에 있는 데이터부터 마지막 방에 있는
//선언한 변수명에 변수를 저장하고 반복 실행문을 실행
foreach ( (컬렉션의 데이터타입) 변수명 in 컬렉션변수 ) 
{
    //반복 실행문
}

*/