using UnityEngine;

//TypeCoversion (형식변환)
public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] long형 변수ㅣ을 선언하고 long형 변수가 가질수 잇는 가장 큰값 저장
        long l = long.MaxValue;
        Debug.Log("l의 값" + l); 
    }
}
