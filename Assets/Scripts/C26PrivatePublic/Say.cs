using UnityEngine;

namespace PrivatePublic
{
    public class Say
    {
        // [1] 필드 선언하고 초기화
        string message = "안녕하세요";      //string 변수 필드 - private
        int[] numbers = { 1, 2, 3, 4, 5 };  //정수형 배열 필드 - private

        public string categoryName;         //string 변수 필드 - public 지정



        // [2] message를 출력하는 멤버 함수 선언
        public void Hi()
        {
            this.message = "반갑습니다";
            Debug.Log(this.message);
        }

        // [3] numbers를 출력하는 멤버 함수 선언
        public void PrintNumber()
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }
        }
    }
}