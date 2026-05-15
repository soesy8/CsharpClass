using UnityEngine;

namespace Constructor
{
    public class ConstructorDemo : MonoBehaviour
    {

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Student 클래스의 (생성자를 호출해서) 인스턴스(객체) 생성
            //Student student = new Student();

            //Dog 클래스의 객체(인스턴스) 생성
            //매개변수가 있는 생성자를 이용하여 객체 생성
            /*Dog happy = new Dog("해피");
            Debug.Log($"강아지 이름은 {happy.GetName()}");

            //Dog 클래스의 다른 객체(인스턴스) 생성
            Dog worry = new Dog("워리");
            Debug.Log($"옆집 강아지 이름은 {worry.GetName()}");*/

            //User 클래스의 인스턴스 생성
            // [1] 기본 생성자 호출
            /*User user1 = new User();
            user1.ShowUserInfo();

            // [2] 매개변수가 있는 생성자 호출
            User user2 = new User("백두산");
            user2.ShowUserInfo();

            User user3 = new User("장길산", 25);
            user3.ShowUserInfo();*/

            //소멸자 테스트
            //DestructorTest 클래스의 인스턴스 생성
            DestructorTest destructorTest = new DestructorTest();
            //인스턴스 사용
            destructorTest.Run();

            //소멸자 호출 - 가비지 컬렉터 (GC) 가 대신 해줌
            //~DestructorTest();    소멸자 호출 사용자가 못함



        }
    }
}
/*
Constructor (생성자) : 클래스가 사용될 때 제일 먼저 호출되는 매서드
: 객체를 새성할 때 호출된다
: 클래스의 필드의 기본 값을 설정하는 역할(필드 초기화), 인스턴스(객체) 초기화

Constructor(생성자) 형식 - 메서드
- 클래스 이름과 동일한 이름으로 함수 이름을 사용
- 접근 제한자는 public 사용
- 반환 값도 없고, void 키워드도 없음

- Constructor(생성자)를 만들지 않으면 닷넷에서 기본 생성자를 자동으로 만들어줌
//기본 생성자
public Dog()
{
}
- 모든 필드의 기본 값으로 초기화 : 값형식(0), 참조형(null)

class Dog (클래스 이름)
{
    //Constructor 생성자
    public Dog()
    {
        
    }

}

*/