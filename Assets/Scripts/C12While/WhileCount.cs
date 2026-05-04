using UnityEngine;

public class WhileCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 1씩 증가하면서 값을 출력
        int i = 1;
        int n = 5;

        while(i <= n)
        {
            Debug.Log($"{i}");
            i++;
        }
        
        Debug.Log("======================");
        
        //5부터 1까지 1씩 감소하면서 값을 출력
        int c = 5;
        int v = 1;

        while(c >= v)
        {
            Debug.Log($"Count : {c}");
            c--;
        }
    }
}
