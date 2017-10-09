using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour {

    public Transform ball;
    public float speed = 2;

	void FixedUpdate ()
    {
        if (ball.position.z > transform.position.z)
            transform.position += Vector3.forward * speed * Time.fixedDeltaTime;

        if (ball.position.z < transform.position.z)
            transform.position -= Vector3.forward * speed * Time.fixedDeltaTime;
    }
}
