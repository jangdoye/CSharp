using UnityEngine;

//TypeCoversion (���ĺ�ȯ)
public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] long�� �������� �����ϰ� long�� ������ ������ �մ� ���� ū�� ����
        long l = long.MaxValue;
        Debug.Log("l�� ��" + l); 
    }
}
