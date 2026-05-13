using UnityEngine;
using System.Linq;
using System.Collections.Generic;


public class LinqNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool형 배열 변수 선언하고 초기화
        bool[] isOut = { true, false, true, false, true };

        //배열의 갯수 구하기, 배열의 값 중에 true 또는 false의 갯수
        Debug.Log(isOut.Count());       // 5
        //true의 갯수
        Debug.Log(isOut.Count(t => t == true));     //람다식 (t => t == true)
        //false의 갯수
        Debug.Log(isOut.Count(a => a == false));    //람다식 (a => a == false)

        //정렬 Sort
        string[] colors = { "Red", "Green", "Blue" };

        //오름차순 정렬
        IEnumerable<string> sortedColors = colors.OrderBy(s => s);

        foreach (var i in sortedColors)
        {
            Debug.Log(i);
        }

        //
        List<string> allColors = new List<string> { "Red", "Green", "Blue" };
        var sColors = allColors.OrderByDescending(s => s);
        foreach (string color in sColors)
        {
            Debug.Log(color);
        }



    }
}
