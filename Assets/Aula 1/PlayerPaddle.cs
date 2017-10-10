using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour {

    public float speed = 2;

    //default speed
    private float defaultSpeed;
    //direction
    private float dir;

    private void Awake()
    {
        defaultSpeed = speed;
    }

    private void Update()
    {
        dir = Input.GetAxis("Vertical");

        //reset speed
        speed = defaultSpeed;
        
        if (true)
        {
            //get the collider around the paddle
            Collider[] colliders = Physics.OverlapSphere(transform.position, transform.localScale.z / 2);
            //for each collider found
            foreach (Collider col in colliders)
            {
                //if it is Border Top and it is going up, stop
                if (col.gameObject.name == "Border Top" && dir > 0)
                {
                    speed = 0;
                    break;
                }

                //if it is Border Bottom and it is going down, stop
                if (col.gameObject.name == "Border Bottom" && dir < 0)
                {
                    speed = 0;
                    break;
                }
            }
        }
    }

    void FixedUpdate()
    {
        transform.position += Vector3.forward * speed * dir * Time.fixedDeltaTime;
    }
}
