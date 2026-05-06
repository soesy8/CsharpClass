using UnityEngine;

//Array(배열) : 하나의 이름으로 같은 데이터 형식을 여러 개 보관해 놓는 그릇
//선언 : 데이터타입[] 변수이름
public class ArrayDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // i) 배열 선언
        int[] numbers;

        // ii) 배열의 요소수 생성, 배열크기(길이) 결정 - 그릇(방) 갯수 n개 지정
        //   배열크기(길이) 결정이 되면 각각의 방이 0으로 초기화
        numbers = new int[10];  // 0 ~ n-1

        // iii) 배열 초기화 - 배열 변수에 값 저장하기
        numbers[0] = 3840;
        numbers[1] = 2160;

        // iv) 배열 사용
        Debug.Log($"{numbers[0]}*{numbers[1]}*{numbers[2]} = {numbers[0] * numbers[1] * numbers[2]}");

    }
}


