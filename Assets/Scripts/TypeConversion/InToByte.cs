using UnityEngine;

public class InToByte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 x를 선언하고 255로 초기화
        int x = 255;

        //byte형 변수 y를 선언하고 x의 값으로 초기화
        //byte 지정범위 : 0~255
        byte y = (byte)x;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
