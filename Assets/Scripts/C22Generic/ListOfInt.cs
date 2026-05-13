using UnityEngine;
using System.Collections.Generic;

//제네릭 리스트
public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 배열 - 정수형 배열 변수 선언하고 요소수 생성
        int[] arrNums = new int[3];
        //배열 초기화
        arrNums[0] = 10;
        arrNums[1] = 20;
        arrNums[2] = 30;
        //배열 사용
        /*for(int i = 0; i < arrNums.Length; i++)
        {
            Debug.Log(arrNums[i]);
        }*/
        foreach(int i in arrNums)
        {
            Debug.Log(i);
        }


        // [2] 제네릭 리스트 사용 : int 전용 <int>
        //List<T> 의 인스턴스를 int 전용으로 생성하고 리스트에 40, 50, 60을 저장
        List<int> listNums = new List<int>();
        listNums.Add(40);
        listNums.Add(50);
        listNums.Add(60);

        /*for(int i = 0; i < listNums.Count; i++)   //Length 말고 Count 쓰는 이유
        {                                           //Length는 고정인데 Count는 유동적이기 때문에
            Debug.Log(listNums[i]);                 //나중에 리스트에 데이터가 추가되어도 따로 수정하지
        }*/                                         //않아도 됌

        foreach (var i in listNums)
        {
            Debug.Log(i);
        }
        Debug.Log("===================");

        listNums.Add(70);
        foreach (var i in listNums)
        {
            Debug.Log(i);
        }

        // [3] 제네릭 리스트 클래스 (List<T>) : List<int>, List<string>, List<float>, List<object>, ...
        // <string> 리스트 인스턴스 생성
        List<string> colors = new List<string>();
        //리스트에 데이터 넣기
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        //리스트 사용
        foreach (var c in colors)
        {
            Debug.Log(c);
        }

    }
}
