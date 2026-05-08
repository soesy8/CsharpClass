using UnityEngine;

//메서드(함수) 오버로드(Method Overload)
//동일한 이름의 메서드를 매개변수를 다르게 해서 여러 개 생성
//함수 다중 정의
public class MethodOverload : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1234출력
        //PrintNumber(1234);
        //PrintNumber(1234.567f);
        //PrintNumber(1234L);

        //인사하기
        Hi();
        Hi("반갑습니다");
        Hi("또 만나요", 3);

    }
    
    //매개변수로 숫자(정수, 실수)를 입력받아 출력하는 함수(PrintNumber)
    void PrintNumber(int num)
    {
        Debug.Log($"int32 : {num}");
    }

    void PrintNumber(float num)
    {
        Debug.Log($"실수형F : {num}");
    }

    void PrintNumber(long num)
    {
        Debug.Log($"int64 : {num}");
    }

    //인사하는 함수
    void Hi()
    {
        Debug.Log("안녕하세요");
    }

    void Hi(string message)
    {
        Debug.Log(message);
    }

    //매개변수로 인사횟수를 입력받아 count만큼 인사하기
    void Hi(string message, int count)
    {
        for(int i = 0; i < count; i++)
        {
            Debug.Log(message);
        }
    }


}
