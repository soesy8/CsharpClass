using UnityEngine;

//이중 for문 : for문 안에 for문
//3중 for문 : for문 안에 for문 안에 for문
public class ForStar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //* 로 삼각형 만들기
        
        for(int i = 1; i <= 5 ;i++)
        {
            Debug.Log($"*을 {i}개 만큼 찍는다");
            for(int j = 0; j < i; j++)
            {
                Debug.Log("*");
            }
        }
    }
}
