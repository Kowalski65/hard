using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        var y = Mathf.Sin(Time.time+speed);

        y = Mathf.Abs(y);
        var x = transform.position.x;
        var z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
}
