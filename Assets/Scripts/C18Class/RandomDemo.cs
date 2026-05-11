using UnityEngine;
using System;

//RandomClass : 랜덤 값 구하는 함수들이 있는 클래스
public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Random 클래스의 인스턴스 생성
        //클래스이름 객체이름 = new 클래스이름();
        System.Random random = new System.Random();

        //랜덤 값 구하기
        Debug.Log(random.Next());       //Next : 임의의 정수를 던져주는(반환하는) 함수
        Debug.Log(random.Next(5));      //0 ~ 4 사이의 정수 중 랜덤 값 반환
        Debug.Log(random.Next(1, 10));  //0 ~ 9 사이의 정수 중 랜덤 값 반환

    }
}

/*


*/