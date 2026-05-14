using UnityEngine;

//네임스페이스로 묶는다
namespace Poo
{
    public class Car
    {
        //인스턴스 메서드
        public void Go()
        {
            Debug.Log("[2]Poo네임 스페이스의 Car 클래스 호출");
        }
        public static void Gogo()
        {
            Debug.Log("[3]Poo Name Car class Gogo method");
        }
    }
}