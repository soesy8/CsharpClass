using UnityEngine;


namespace Constructor
{
    public class DestructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //소멸자 테스트
            //DestructorTest 클래스의 인스턴스 생성
            /*DestructorTest destructorTest = new DestructorTest();
            //인스턴스 사용
            destructorTest.Run();*/

            //소멸자 호출 - 가비지 컬렉터 (GC) 가 대신 해줌
            //~DestructorTest();    소멸자 호출 사용자가 못함

            //Car 클래스의 객체(인스턴스) 생성
            //흰차, 파란차, 빨간차 만들기
            Car whiteCar = new Car();
            whiteCar.Run();

            Car blueCar = new Car("파란");
            blueCar.Run();

            Car redCar = new Car("빨간");
            redCar.Run();

            //폐차는 GC가 알아서 함

        }
    }
}

/*
Destructor (소멸자) : 클래스가 사용된 후 가장 마지막에 호출되는 메서드
: 생성된 객체(인스턴스)가 메모리 상에서 없어질 때 호출
: 클래스에서 사용된 메모리 해제 .. 등

가비지 컬렉터 GC :

class Dog(클래스이름)
{
    //생성자
    public Dog()
    {
    }

    //소멸자
    ~Dog()
    {
        //개체가 소멸할 때 필요한 기능 수행
    }
}




*/