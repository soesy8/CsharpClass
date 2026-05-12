using UnityEngine;
using System;

public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //로또번호 생성기
        //[1] 6개 번호 - 배열 변수 선언 및 요소수 생성
        /*
        int[] rottoNumbers = new int[6];

        //중복 검사
        //rottoNumbers[0] : x
        //rottoNumbers[1] : [0]
        //rottoNumbers[2] : [0], [1]
        //rottoNumbers[3] : [0], [1], [2]
        //rottoNumbers[4] : [0], [1], [2], [3]
        //rottoNumbers[5] : [0], [1], [2], [3], [4]

        //Random 객체 가져오기
        System.Random rand = new System.Random();

        //필요 변수
        int number = 0;     //랜덤번호 받아오는 값
        bool flag = false;  //중복 검사, true면 중복

        //임의의 숫자 6개 번호 생성 : 1~45 사이의 랜덤 값
        for (int i = 0 ; i < 6; i++)
        {
            //1~45 사이의 랜덤 값
            number = rand.Next(1, 46);
            
            //중복 체크 초기화
            flag = false;

            //중복 검사
            for(int j = 0; j < i; j++)
            {
                if(number == rottoNumbers[j])
                {
                    //중복 체크
                    flag = true;
                }                
            }
            
            if(flag == false)   //중복이 아니면
            {
                //임의의 숫자 6개 번호 저장
                rottoNumbers[i] = number;
            }
            else    //중복이면
            {
                i--;
            }
        }

        //임의의 숫자 6개의 번호 출력
        for (int i = 0; i < 6; i++)
        {
            Debug.Log($"{rottoNumbers[i]}");
        }

        */


        //[1], [2] 임의의 숫자 6개 번호 생성, 저장
        System.Random random = new System.Random();
        
        int[] arr = new int[6];                 //6개 숫자 저장할 배열 생성

        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 46);        //랜덤숫자 생성 및 저장
            for(int j = 0; j < i; j++)          //중복 검사
            {
                if (arr[i] == arr[j])           //arr[5] == arr[0] > arr[3] == arr[1] > ...
                {                               //if(arr[5] != arr[1])
                    i--;                        //i-- > i = 4 > break > i++ > i = 5 // 중복 발생 시 숫자 재생성
                    break;
                }
            }
        }

        //[3] 임의의 숫자 6개 번호 출력
        /*for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log($"{arr[i]}");
        }*/
        foreach (int a in arr)
        {
            Debug.Log(a);
        }
            
    }
}

/*
//로또번호 생성기
[1] 6개 번호
[2] 1 ~ 45번 사이의 랜덤 번호
[3] 6개의 번호가 중복되지 않는다

3가지 조건이 맞는 6개의 번호를 출력하는 프로그램 구현

[1] 임의의 숫자 6개 번호 생성 : ( 1 ~ 45 ) 사이의 랜덤 값
[2] 임의의 숫자 6개 번호 저장
[3] 임의의 숫자 6개 번호 출력

[4] 중복 제거 기능 추가 - [2]와 [3] 사이에 추가
*/