using UnityEngine;


namespace Method
{

    public class MethodDemo : MonoBehaviour
    {

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스의 인스턴스 생성
            Dog dog = new Dog();
            dog.Eat();      // 인스턴스 메서드
            //dog.Digest(); // error, private 인스턴스 메서드

            Dog.Drink();    // 정적 메서드
            //dog.Dring();  // error, 정적 메서드, 인스턴스 이름으로 호출 불가


        }
    }
}

/*
Method(메서드, 함수, function)
: 클래스가 수행하는 기능을 하나의 이름으로 묶어서 관리하는 코드블록
: 클래스의 기능 구현

= 메서드 네이밍
: 동사 + 명사
: GetName, SetName, GetHp, Run ...

[1] 메서드 구성 요소
public(private, protected) static(x) void(반환값, int, string, boo, object ..) 메서드이름(매개변수)
{
    //실행 명령문들 ...
}


*/