using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour {

    public float speed = 2;

    void FixedUpdate()
    {
        float dir = Input.GetAxis("Vertical");
        transform.position += Vector3.forward * speed * dir * Time.fixedDeltaTime;
    }
}
