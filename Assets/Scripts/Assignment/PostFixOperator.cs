using UnityEngine;

//PostFixOperator(���� ����(++,--) ������): ���� ���ο��� �����ϴ� �켱������ ���� ����(���� ���߿� ����)
public class PostFixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = x++;
        Debug.Log("x: " + x); //4
        Debug.Log("y: " + y); //3
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
