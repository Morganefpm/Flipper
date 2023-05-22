using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bump : MonoBehaviour
{
    public float force = 100f;
    public float forceR = 1f;
    public int scorV = 100;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Collider col in Physics.OverlapSphere(transform.position, forceR))
        {
            if ( col.GetComponent<Rigidbody>())

            {
                col.GetComponent<Rigidbody>().AddExplosionForce(forceR, transform.position, forceR);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
