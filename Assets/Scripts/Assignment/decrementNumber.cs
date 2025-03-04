using System.Diagnostics;
using UnityEngine;

//정수형 변수의 값을 1 감소
public class decrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 10;   //num =  10
        num = num - 1;  //num 1 감소식

        UnityEngine.Debug.Log(num);
    }
}
