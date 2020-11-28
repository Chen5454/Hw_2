using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton
{

    public int score;

    private static MySingleton _instance;
    private MySingleton() { }
    
    public static MySingleton GetSingleton()
    {
        if (_instance == null)
        {
            _instance = new MySingleton();
        }
        return _instance;
    }
}
