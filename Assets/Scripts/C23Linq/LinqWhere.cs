using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqWhere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 배열 선언하고 초기화
        int[] nums = { 1, 2, 3, 4, 5, 6 };

        //nums 배열의 요소 중 3보다 크고 짝수인 수를 구해서 리스트에 넣기
        List<int> listnums = nums.Where(n => n > 3 && n % 2 == 0).ToList();
        foreach (int i in listnums)
        {
            Debug.Log(i);
        }


    }
}
