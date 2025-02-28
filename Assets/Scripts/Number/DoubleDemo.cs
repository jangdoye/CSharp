using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double d = 3.141592d;   //64비트 실수형 데이터 형식 선언 및 초기화   
        float f = 3.14f;        //32비트 실수형 데이터 형식 선언 및 초기화
        decimal m = 12.34m;     //128비트 실수형 데이터 형식 선언 및 초기화

        Debug.Log(d);
        Debug.Log(f);
        Debug.Log(m);

        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;

        Debug.Log("double 최소값" + doubleMin);
        Debug.Log("double 최대값" + doubleMax);

        float floatMin = float.MinValue;
        float floatMax = float.MaxValue;

        Debug.Log("float 최소값" + floatMin);
        Debug.Log("float 최대값" + floatMax);
    }
}
