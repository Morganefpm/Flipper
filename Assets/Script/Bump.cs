using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    type1,
    type2, type3, type4, type5, type6, type7, type8, type9, type10, type11
}
public class Bump : MonoBehaviour
{
    public float force = 100f;
    public float forceR = 1f;

    void Start()
    {
        foreach (Collider col in Physics.OverlapSphere(transform.position, forceR))
        {
            //if ( col.GetComponent<Rigidbody>())
            //{
            //    col.GetComponent<Rigidbody>().AddExplosionForce(forceR, transform.position, forceR);
            //}
            if (TryGetComponent(out Rigidbody rb))
            {
                rb.AddExplosionForce(forceR, transform.position, forceR);
            }
        }
    }
}
