using UnityEngine;
using Bar;

//namespace
public class NameSpaceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Bar 네임스페이스 Car 클래스의 인스턴스(객체) 생성 - 인스턴스 메서드 호출
        Car barCar = new Car();
        barCar.Go();

        //Poo 네임스페이스 Car 클래스의 인스턴스(객체) 생성 - 인스턴스 메서드 호출
        Poo.Car pooCar = new Poo.Car();
        pooCar.Go();

        Debug.Log("==========");
        Poo.Car.Gogo();
    }
}

/*
//NameSpace (네임 스페이스) : 클래스 등을 묶어서 관리하는 구조 
1. 같은 이름 충돌 방지
2. 관련있는 기능끼리 모아놓기

namespace 네임스페이스이름
{
    //class
}
*/
/*namespace MyGame.Character
{
    public class Player
    {
        public void SayHello()
        {
            Debug.Log("ㅎㅇ");
        }
    }
}*/