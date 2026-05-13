using UnityEngine;
using System.Linq;

//링크 (Linq) : 컬렉션 형태의 데이터를 가공할 때 유용한 메서드를 많이 제공
//확장 메서드 : 특정 형식에 원래 없던 기능을 덧붙이는 개념으로 제공하는 함수
public class LinqDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정수형 배열 선언하고 초기화
        int[] nums = { 1, 2, 4 };

        // [2] 배열 사용하기
        int count = nums.Count();
        Debug.Log($"count : {count}");

        int sum = nums.Sum();
        Debug.Log($"sum : {sum}");

        double avg = nums.Average();
        Debug.Log($"avg: {avg:F2}");

        int max = nums.Max();
        Debug.Log($"max : {max}");

        int min = nums.Min();
        Debug.Log($"min : {min}");
    }
}
