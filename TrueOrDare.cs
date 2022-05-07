using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueOrDare : MonoBehaviour
{
    int a = 500;
    int b = 24;
    
    // Start is called before the first frame update
    void Start()
    {
        Verify(a, b);
    }

    bool answerOne;

    void Verify(int x, int y)
    {

        if (
            x - y > 0)
        {
            answerOne = true;
        }

        else
        {
            answerOne = false;
        }

            Debug.Log(answerOne);
    }
}
