using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string B = "Ȧ��";

        const int A = 3;
        Debug.Log($"{A} ��(��) {B} ");
    }
}
