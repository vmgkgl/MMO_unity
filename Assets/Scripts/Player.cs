using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        Managers mg = Managers.GetInstance();
        Debug.Log("mg : " + mg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
