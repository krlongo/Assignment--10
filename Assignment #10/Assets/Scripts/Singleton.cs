using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
    private static Singleton uniqueInstance;

    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (uniqueInstance == null)
        {
            uniqueInstance = new Singleton();
        }
        return uniqueInstance;
    }
}
