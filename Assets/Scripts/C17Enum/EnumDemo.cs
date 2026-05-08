using UnityEngine;

// i) 동물들을 구분하는 열거형 정의,선언
enum Animal
{
    Mouse,      //0
    Cow = 5,    //1 => 5
    Tiger       //2 => 6
}




public class EnumDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ii) 열거형(Animal) 변수 선언하고 초기화
        Animal animal = Animal.Tiger;
        Debug.Log(animal);

        int number = (int)animal;
        Debug.Log($"{animal} : {number}");

        //열거형 조건문
        /*if (animal == Animal.Tiger)
        {
            Debug.Log("호랑이");
        }*/

        //조건문의 데이터가 열거형 데이터일 경우 defualt 필요없음 / 다른 값을 넣으면 오류 뜨기 때문
        /*switch(animal)
        {
            case Animal.Mouse:
                Debug.Log("쥐");
                break;

            case Animal.Cow:
                Debug.Log("소");
                break;

            case Animal.Tiger:
                Debug.Log("호랑이");
                break;
        }*/

        PrintAnimal(animal);
    }

    //매개변수로 들어온 enum값에 따라 동물 이름 출력
    void PrintAnimal(Animal ani)
    {
        switch (ani)
        {
            case Animal.Mouse:
                Debug.Log("쥐");
                break;

            case Animal.Cow:
                Debug.Log("소");
                break;

            case Animal.Tiger:
                Debug.Log("호랑이");
                break;
        }
    }

}

/*
Enum (열거형, Enumeration) : 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수들의 집합
: 사용자 정의 데이터 형식 - 변수처럼 사용
: enum의 변수에는 정의에서 열거된 상수 이름만 저장된다
: (개발자가 만든 enum) 변수이름;

: enum 선언시 맨 위에 있는 상수 이름의 상수 값은 0이다
: 맨 위에 있는 상수를 제외한 다른 상수들의 값은 바로 위에 있는 상수의 값 +1;
: 각각의 상수 이름들은 선언 시 상수 값을 초기화할 수 있다

== Enum의 형식
enum (enum 이름)
{
    상수 이름,  //상수값 : 0
    상수 이름,  //상수값 : 상수 이름1 값 +1
    상수 이름,  //상수값 : 상수 이름2 값 +1
    ...
}



*/