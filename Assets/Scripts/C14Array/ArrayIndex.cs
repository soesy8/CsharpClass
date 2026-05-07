using UnityEngine;


public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //크기가 3인 정수형 배열 선언하고 1,2,3 으로 초기화
        //int[] numbers = new int[3] { 1, 2, 3 };
        int[] numbers = { 1, 2, 3 };
        //numbers[0] = 1
        //numbers[1] = 2
        //numbers[2] = 3

        //배열의 인덱스를 관리하는 변수 선언 : 범위(0~2), 0으로 초기화
        int index = 0;

        Debug.Log(numbers[index++]);    //1 /numbers[0] > index++ > numbers[1]
        Debug.Log(numbers[index++]);    //2 /numbers[1] > index++ > numbers[2]
        Debug.Log(numbers[index++]);    //3 /numbers[2] > index++ > numbers[3]
                                        //numbers[3] 그대로 출력하면IndexOutOfRangeException 오류 발생
        

        Debug.Log(numbers[--index]);    //3 /numbers[3] > index-- > numbers[2] > 출력
        Debug.Log(numbers[--index]);    //2 /index-- > numbers[1]
        Debug.Log(numbers[--index]);    //1 /index-- > numbers[0]
        //Debug.Log(number[--index]);   //numbers[0] > index-- > numbers[-1]
                                        //IndexOutOfRangeException 오류 발생
    }
}

/*



*/