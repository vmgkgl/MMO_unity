using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabtest : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        GameObject tank = Managers.Resource.Instantiate("Tank");
        Managers.Resource.Destroy(tank, 3.0f);
    }
}
