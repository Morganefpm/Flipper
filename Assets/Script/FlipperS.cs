using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

[RequireComponent(typeof(HingeJoint))]
public class FlipperS : MonoBehaviour
{
    private HingeJoint hinge;
    private JointSpring spring;

    [Header("Parameters")]
    
    [SerializeField] private float restPosition = 0f;
    [HideInInspector] public float PressedPosition = 45f;
    [Tooltip("ca sert a r")] public float HitStrenght = 10000f;
    public float FlipperDamper = 150f;
    public string InputName = "Horizontal";

    public bool IsOnGround = false;

    //Dictionary<string, int> bouh; LIST AVEC KEY VALUE EN PLUS

    void Awake() // INIT VALUE THIS AVANT START
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;

        spring = new JointSpring();
        spring.spring = HitStrenght;
        spring.damper = FlipperDamper;
    }


    void Update()
    {
        IsOnGround = OnGround();
        PressFlipper();
        Debug.Log(IsOnGround);
    }

    public void PressFlipper()
    {
        if (Input.GetAxis(InputName) == 1)
        {
            spring.targetPosition = PressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }

    public bool OnGround()
    {
        // logic raycast
        return true;  
    }
}
