using UnityEngine;

//PostFixOperator(후위 증감(++,--) 연산자): 같은 라인에서 연산하는 우선순위가 가장 낮음(가장 나중에 연산)
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
