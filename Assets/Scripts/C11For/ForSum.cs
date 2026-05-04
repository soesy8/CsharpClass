using UnityEngine;

//1부터 n까지의 합을 구하는 프로그램 구현
public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int n = 20;
        int sum = 0;    //합을 저장할 변수

        for(int i = 1; i <= n; i++)
        {
            sum = sum + i; //i 누적식
        }
        
        Debug.Log($"합은 {sum}");*/

        //1부터 10까지의 정수 중 짝수의 합을 구하는 프로그램 구현

        int n = 10;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            if(i % 2 == 0)
            {
                sum = sum + i;
            }
        }
        
        Debug.Log($"1부터 {n}까지의 정수 중 짝수의 합은 {sum}");

    }
}
