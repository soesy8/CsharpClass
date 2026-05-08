using UnityEngine;

//두 개의 정수를 입력받아 사칙연산(+,-,*,/(0으로 나누기 제외),%) 값을 구하는 프로그램 구현
public class FunctionPractice : MonoBehaviour
{
    public int a = 0;
    public int b = 0;

    public bool usePlus = true;
    public bool useMinus = true;
    public bool useTimes = true;
    public bool usePer = true;
    public bool usePercent = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ExecuteCalculation($"{a} + {b}", usePlus, Plus(a, b));
        ExecuteCalculation($"{a} - {b}", useMinus, Minus(a, b));
        ExecuteCalculation($"{a} * {b}", useTimes, Times(a, b));
        ExecuteCalculation($"{a} / {b}", usePer, Per(a, b));
        ExecuteCalculation($"{a} % {b}", usePercent, Percent(a, b));

        /*if (usePlus)
        {
            int plusValue = Plus(a, b);
            Debug.Log($"{a} + {b} = {plusValue}");
        }

        if (useMinus)
        {
            int minusValue = Minus(a, b);
            Debug.Log($"{a} - {b} = {minusValue}");
        }

        if (useTimes)
        {
            int timesValue = Times(a, b);
            Debug.Log($"{a} * {b} = {timesValue}");
        }

        if (usePer)
        {
            float perValue = Per(a, b);
            Debug.Log($"{a} / {b} = {perValue}");
        }

        if (usePercent)
        {
            int percentValue = Percent(a, b);
            Debug.Log($"{a} % {b} = {percentValue}");
        }*/
    }

    void ExecuteCalculation(string label, bool useExecute, float result)
    {
        if (useExecute)
        {
            Debug.Log($"{label} = {result}");
        }
    }
    
    //+
    int Plus(int a, int b)
    {
        /*int plusResult;
        return plusResult = a + b;*/
        return (a + b);
    }

    //+ 심화
    //int morePlus(int a, int b) => a + b;

    //-
    int Minus(int a, int b)
    {
        /*int minusResult;
        return minusResult = a - b;*/
        return (a - b);
    }

    //*
    int Times(int a, int b)
    {
        /*int timesResult;
        return timesResult = a * b;*/
        return (a * b);
    }

    //나누기
    float Per(float a, float b)
    {
        //float perResult;
        if( b == 0)
        {
            Debug.Log("0으로는 나눌 수 없습니다.");
            return 0;
        }
        //return perResult = a / b;
        return (a / b);
    }

    //%
    int Percent(int a, int b)
    {
        //*int percentResult;
        //return percentResult = a % b;*
        return (a % b);
    }

}
