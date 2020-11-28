using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

      void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            MySingleton.GetSingleton().score++;

            Debug.Log("**DING** You Gain An Extra Coin! Total Of Coins is : "+ MySingleton.GetSingleton().score);
        }

    }

}
