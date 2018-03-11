using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {

    public Camera target;

    void Update () {
        Vector3 pos = target.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = target.ViewportToWorldPoint(pos);
        transform.position = new Vector3(transform.position.x, transform.position.y, target.transform.position.z + 1f);
        //transform.position = new Vector3(target.position.x, transform.position.y, target.position.z + 1);
        // SetTransformX(target.position.x + 10);
        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, .03f);
    }

    void SetTransformX(float x)
    {
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }

}
