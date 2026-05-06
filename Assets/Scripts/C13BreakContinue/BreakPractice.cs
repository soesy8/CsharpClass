using UnityEngine;

// 1부터 10까지의 정수의 합을 구하는 프로그램 구현 / 55
// 단 합을 구하다 합이 22이 이상이 되면 더 이상 합을 구하지 말고 합을 출력하라

public class BreakPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        
        for(int i = 1; i <=10; i++)
        {
            sum += i;
            
            if(sum >= 22)
            {
                Debug.Log($"합은 {sum}");
                break;
            }
        }

        /*
                int i = 1;
                int sum = 0;
                while (i <= 10)
                {
                    sum += i;
                    if (sum >= 22)
                    {
                        break;
                    }
                    i++;
                }
                Debug.Log($"합은 {sum});
        */
    }
}
