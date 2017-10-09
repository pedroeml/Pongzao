using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycasterBall : MonoBehaviour {

    public Vector3 velocity;

    Ray r;
    RaycastHit rh;

	// Use this for initialization
	void Start () {
        r = new Ray();
        rh = new RaycastHit();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        r.origin = transform.position;
        r.direction = velocity.normalized;
        if (Physics.Raycast(r, out rh, velocity.magnitude * Time.fixedDeltaTime + 0.01f))
        {
            transform.position = rh.point;
            velocity = Vector3.Reflect(velocity, rh.normal);
        }
        else
            transform.position += velocity * Time.fixedDeltaTime;


        GameManager gm = Component.FindObjectOfType<GameManager>();
        if(transform.position.x < gm.leftBorder)
        {

        }
        if (transform.position.x > gm.rightBorder)
        {

        }

    }
}
