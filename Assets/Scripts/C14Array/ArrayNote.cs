using UnityEngine;

public class ArrayNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // i) 배열 선언 및 요소수(갯수) 생성, 초기화
        //int[] intArray = new int[3] { 1, 2, 3 };
        // ii) 배열 선언 및 요소수(갯수) 생성 랭략, 초기화
        //int[] intArray = new int[] { 1, 2, 3 };
        int[] intArray = { 1, 2, 3 };

        // iv) 배열 사용
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log($"intArray[{i}]: {intArray[i]}");
        }
    }
}
