using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string B = "È¦¼ö";

        const int A = 3;
        Debug.Log($"{A} Àº(´Â) {B} ");
    }
}
