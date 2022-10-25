using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{
    int num1 = 314;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(product(num1));
    }

    int product(int num1)
    {
        return (num1 * 2);
    }



}
