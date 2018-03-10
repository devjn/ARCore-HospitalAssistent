using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class LookAt : MonoBehaviour {


    public Transform target;

    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
        }
    }

}
