using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerador : MonoBehaviour {

    public float increasedSpeed = 1;
    public ParticleSystem effect;

    private void OnTriggerEnter(Collider other)
    {
        var b = other.GetComponent<RaycasterBall>();
        if (b != null)
        {
            b.velocity += b.velocity.normalized * increasedSpeed;
            effect.transform.position = b.transform.position;
            effect.Play();
        }
    }
    
}
