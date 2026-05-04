using UnityEngine;

// 1부터 100까지의 정수 중에 3의 배수 또는 4의 배수를 구해서 합하는 프로그램을 구현
public class SumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        int n = 100;
        int sum = 0;
        
        while(i <= n)
        {
            if(i % 3 == 0 || i % 4 == 0)
            {
                sum = sum + i;
            }
            i++;
        }
        Debug.Log($"3 또는 4의 배수의 합은 {sum}");

        Debug.Log("===========================");

        sum = 0;

        for(int a = 0; a <= 100; a++)
        {
            if (a % 3 == 0 || a % 4 == 0)
            {
                sum = sum + a;
            }
        }
        Debug.Log($"3 또는 4의 배수의 합은 {sum}");

    }
}
