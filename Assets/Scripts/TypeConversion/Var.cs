using UnityEngine;

//var : �Ͻ������� ����ȭ�� ���� ����
//var ����� ������ �ʱ�ȭ�� �ݵ�� �Ѵ�
public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name = "ȫ�浿";      //������ �ԷµǴ� ��("ȫ�浿")�� ���� name ������string �������� ����
        Debug.Log(name);
        Debug.Log(name.GetType());

        var version = 8.0;        //������ �ԷµǴ� ��(8.0)�� ���� name������ double �������� ����
        Debug.Log(version);
        Debug.Log(version.GetType());
        var car = 1;              //������ �ԷµǴ� ��(1)�� ���� car������ int�������� ����
        Debug.Log(car);
        Debug.Log(car.GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
