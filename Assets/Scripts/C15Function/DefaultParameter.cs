using UnityEngine;

//기본 매개변수 (DefaultParameter, 선택적 매개변수) : 매개변수를 선언할 떄 초기화 한 것
public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //기본 매개변수가 있는 함수 사용
        PrintError("에레 메세지", 4);
        PrintError("다른 메세지");
    }

    //매개변수를 들어온 에러 메세지(문자열)와 레벨(정수)을 출력하는 함수
    // level : 기본 매개변수
    void PrintError(string message, int level = 1)
    {
        Debug.Log($"Error : {message}, Level : {level}");
    }

}
