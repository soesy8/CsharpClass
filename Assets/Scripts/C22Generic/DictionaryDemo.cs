using System.Collections.Generic;
using UnityEngine;



public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Dictionary 제네릭 클래스
        // Dictionary<TKey,TValue> 인스턴스 생성 IDictionary(인터페이스)
        IDictionary<string, string> data = new Dictionary<string, string>();

        // [2] Dictionary 데이터 입력 : 키, 값을 매칭해서 입력
        data.Add("도", "경기도");
        data.Add("시", "서울시");
        data.Add("동", "천호동");

        // [2-2] Dictionary 데이터 입력 2 : 인덱서를 사용해서 입력
        data["구"]/* []부분이 인덱서 */ = "장안구";

        // [3] Dictionary 데이터 삭제
        data.Remove("도");       //Dictionary의 키부분에 입력한 값 삭제

        // [5] Dictionary Key 값이 중복 불가 : 사용 시 에러가 발생
        try
        {
            data.Add("구", "수성구");
        }
        catch(System.Exception ex)
        {
            Debug.Log(ex.Message);
        }

        // [6] Dictionary 사용
        foreach(KeyValuePair<string, string> item in data)
        {
            Debug.Log($"{item.Key},{item.Value}");
        }

        // [6-2] Dictionary 사용 2 : 인덱서를 이용
        Debug.Log(data["동"]);
    }
}
