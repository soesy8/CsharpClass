using UnityEngine;
using Korea.Seoul;      //Korea.Seoul에 있는 클래스를 바로 가져다 사용

using Su = Korea.Suwon; //Korea.Suwon을 Su 라는 별칭으로 지정
public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] using 을 선언해서 클래스 가져오기 - 인스턴스 생성
        Car seoul = new Car();
        seoul.Run();                //서울 자동차

        // [2] using 을 사용하지 않고 클래스 가져오기
        //네임스페이스.클래스이름 으로 가져오기
        Korea.Seoul.Car se = new Korea.Seoul.Car();
        se.Run();                   //서울 자동차

        Truck trk = new Truck();
        trk.Run();                  //서울 트럭

        // [3] 별칭 사용해서 클래스 가져오기 - 인스턴스 생성
        //Korea.Suwon.Car.Run(); => 별칭 Su 지정 => Su.Car.Run();
        Su.Car.Run();      //수원 자동차


    }
}


