using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //double�� �Ǽ��� ���� d�� �����ϰ� 12.34�� �ʱ�ȭ
        double d = 12.34;
        //int�� ������ ���� i�� �����ϰ� 1234�� �ʱ�ȭ
        int i = 1234;

        Debug.Log("�Ϲ����� ���ĺ�ȯ:" + d);

        //[1] double > int : ������(�Ϲ���, �Ͻ���) ���� ��ȯ

        d = i;

        d = 12.34;
        i = 1234;

        //[2] int < double :������� ���� ��ȯ �ʿ�
        i = (int)d; //() : ĳ��Ʈ ������

        Debug.Log("������� ���ĺ�ȯ:" + i);

        //
        string s = ""; //string ���� s�� �����ϰ� ""(��)���� �ʱ�ȭ
        s = d.ToString();
        Debug.Log("�ٸ� ���ĺ�ȯ" + s);

    }
}
