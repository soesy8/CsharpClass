using UnityEngine;

namespace PrivatePublic
{
    //Truck 클래스의 정적, 인스턴스 필드, 메서드를 활용해보는 클래스
    public class FieldStatic : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] static 필드, 메서드 접근해서 사용
            //static 멤버 접근 : 클래스이름.스태틱멤버이름
            Truck.name = "핸들이 고장난 8t 트럭";
            string tName = Truck.GetName();
            Debug.Log(tName);

            //Truck.age = 21;  x
            //Truck.GetAge();  x
            // [2] private한 인스턴스 필드 접근
            //public한 메서드를 이용하여 접근
            Truck truck = new Truck();
            truck.SetAge(25);
            Debug.Log(truck.GetAge());

        }
    }
}