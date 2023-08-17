using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Managers : MonoBehaviour
{
    static Managers s_Instance;

    public static Managers Instance
    {
        get
        {
            Init();
            return s_Instance;
        }
    }

    private void Start()
    {
        Init();
    }

    private static void Init()
    {
        if (s_Instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject("@Managers");
                s_Instance = go.AddComponent<Managers>();
            }
            s_Instance = go.GetComponent<Managers>();
            
        }
    }
}