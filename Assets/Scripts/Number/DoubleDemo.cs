using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double d = 3.141592d;   //64��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ   
        float f = 3.14f;        //32��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ
        decimal m = 12.34m;     //128��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log(d);
        Debug.Log(f);
        Debug.Log(m);

        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;

        Debug.Log("double �ּҰ�" + doubleMin);
        Debug.Log("double �ִ밪" + doubleMax);

        float floatMin = float.MinValue;
        float floatMax = float.MaxValue;

        Debug.Log("float �ּҰ�" + floatMin);
        Debug.Log("float �ִ밪" + floatMax);
    }
}
