using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW1 : MonoBehaviour
{
   // int InputNo = 1;
    // Start is called before the first frame update
    void Start()
    {
        DivBy3and5();
    }

    void DivBy3and5()
    {
        int x = 1;

        for (; x <= 100; x++)
        {
            if (x % 15 == 0)
            {
                Debug.Log("FizzBuzz");
            }

            else if (x % 3 == 0)
            {
                Debug.Log("Fizz");
            }


            else if (x % 5 == 0)
            {
                Debug.Log("Buzz");
            }


            else
            {
                Debug.Log(x);
            }
        }
    }
}