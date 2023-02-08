using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    public float JetpackAcceleration = 1.0f; //accelerates 1 unit per second, per second
    public float MaxJetpackVelocity = 5.0f;
    
    private Vector3 _lastVel;
    private CharacterController _controller;
    
    void Awake()
    {
        _controller = this.GetComponent<CharacterController>();
    }
    
    void Update()
    {
        Vector3 mv = _lastVel;
        if(Input.GetKey(KeyCode.E))
        {
            mv.y += JetpackAcceleration * Time.deltaTime; //the acceleration happens over a duration
                
        }
        if (mv.y > MaxJetpackVelocity) mv.y = MaxJetpackVelocity; //clamp the velocity
    
        //... do other movement stuff, like gravity and the sort... note jetpack acceleration has to be GREATER than grav, OR you have to NOT apply gravity while pressing E
    
        _controller.Move(mv * Time.deltaTime); //move is done over a duration as well
        _lastVel = _controller.velocity; //velocity property of CharacterController is the velocity after 'Move' is called
    }
    
}
