using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floats : MonoBehaviour
{
    float MyBiologicalAge = 22F;
    float MyMentalAge = 11F;
    float MyIQ = 1.23456F;
    float MyMoney = 12.3456F;
    float MyEQ = 123.456F;
    float MySQ = 1234.56F;
    
    // Start is called before the first frame update
    void Start()
    {
        float MyMaturityRatio = (MyMentalAge / MyBiologicalAge);
        float MyNetWorth = (MyIQ + MyMoney + MyEQ + MySQ);

        Debug.Log("My Maturity Ratio = " + MyMaturityRatio + "Facepalms");
        Debug.Log("My Net Worth = " + MyNetWorth + "Memes");
    }

   
}
