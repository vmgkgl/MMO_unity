using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Managers : MonoBehaviour
{
    static Managers Instance;

    public static Managers GetInstance()
    {
        Init();
        return Instance;
    }

    private void Start()
    {
        Init();
    }

    private static void Init()
    {
        if (Instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject("@Managers");
                Instance = go.AddComponent<Managers>();
            }
            else
            {
                Instance = go.GetComponent<Managers>();
            }
        }
    }
}