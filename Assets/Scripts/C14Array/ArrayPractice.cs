using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int[] nums;
        nums = new int[3];
        nums[0] = 1;
        nums[1] = 2;
        nums[2] = 3;

        for(int i = 0; i < 3; i++)
        {
            Debug.Log($"{nums[i]}");
        }*/

        int[] nums = { 1, 2, 3 };
        
        foreach(int n in nums)
        {
            Debug.Log($"{n}");
        }
    }
}
