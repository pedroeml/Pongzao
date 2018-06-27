using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerador : MonoBehaviour {

    public float increasedSpeed = 0.7f;
    public ParticleSystem effect;
	private int count = 0;
	private readonly int MAX_COUNT = 8;

    private void OnTriggerEnter(Collider other)
    {
        RaycasterBall b = other.GetComponent<RaycasterBall>();
        if (b != null)
        {
			if (count < MAX_COUNT) {
				b.velocity += b.velocity.normalized * increasedSpeed;
				count += 1;
			}
            effect.transform.position = b.transform.position;
            effect.Play();
        }

        PhysicBall pb = other.GetComponent<PhysicBall>();
        if (pb != null)
        {
            var r = pb.GetComponent<Rigidbody>();
			if (count < MAX_COUNT) {
				r.AddForce (r.velocity.normalized * increasedSpeed, ForceMode.Impulse);
				count += 1;
			}
			effect.transform.position = pb.transform.position;
            effect.Play();
        }
    }
    
}
