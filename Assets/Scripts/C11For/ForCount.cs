using UnityEngine;

//1부터 5까지 1씩 증가하면서 값을 출력하는 프로그램 구현
public class ForCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < 5; i++)  //가독성이 좋고, 대량의 데이터를 활용할 때 좋음
        {
            Debug.Log($"Count : {i + 1}");
        }
        
        /*for(int i = 1; i <= 5; i++)
        {
            Debug.Log($"Count {i}");
        }*/
        
        /*for(int i = 1; i < 6; i++)
        {
            Debug.Log($"count : {i}");
        }*/

        Debug.Log("================================");

        for (int i = 5; i >= 0; i--)
        {
            Debug.Log($"CountDown : {i}");
        }

        //무한루프
        /*for(;;)
        {
            //반복 실행문
            Debug.Log("무한루프");
        }*/

    }
}
