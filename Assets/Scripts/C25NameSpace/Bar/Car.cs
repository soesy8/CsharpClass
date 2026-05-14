using UnityEngine;

//Bar라는 네임 스페이스로 묶는다
namespace Bar
{
    public class Car
    {
        //인스턴스 메서드
        public void Go()
        {
            Debug.Log("[1]Bar네임 스페이스의 Car 클래스 호출");
        }
    }
}