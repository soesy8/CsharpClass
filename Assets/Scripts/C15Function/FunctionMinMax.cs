using UnityEngine;

//두 수(a, b)를 입력받아 두 수 중 작은 수, 큰 수를 찾는 프로그램 구현
//입력받은 정수의 절대값을 구하는 프로그램
// |-5| = 5, |5| = 5, |-99| = 99
public class FunctionMinMax : MonoBehaviour
{
    //Inspector창 입력
    public int x = 0;
    public int y = 0;
    public int z = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int result = Min(-5, -3);
        Debug.Log(result);

        Debug.Log(Max(5,3));*/

        //a와 b의 작은 값 구하기, 큰 값 구하기
        int minValue = Min(x, y);
        Debug.Log($"작은 값은 {minValue}");
        int maxValue = Max(x, y);
        Debug.Log($"큰 값은 {maxValue}");

        int AbsResult = Abs(z);
        //int absValue = Mathf.Max( AbsResult, z)
        Debug.Log($"{z}의 절대값은 {AbsResult}");

    }

    //매개변수로 입력받은 두 정수 중 작은 수를 반환하는 함수
    int Min(int x, int y)
    {
        if (x < y) { return x; }
        else { return y; }
    }

    int Max(int x, int y)
    {
        /*int maxValue = 0;
        if (x < y ) { maxValue = y; }
        else { maxValue = x; }
        return maxValue;*/

        //3항 연산자 : (조건식) ? 참일 때 반환 값 : 거짓일 때 반환 값
        /*int maxValue = (x > y) ? x : y;

        return maxValue;*/

        return (x > y) ? x : y;
    }

    //매개변수로 입력받은 정수의 절대값을 반환하는 함수
    // |-5| = 5, |5| = 5, |-99| = 99
    int Abs(int num)
    {
        return (num < 0) ? -num : num;
    }

    
}
