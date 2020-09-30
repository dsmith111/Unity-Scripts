using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    public float speed = 95f;

    public Rigidbody2D rbd2D;
    public FixedJoystick joy_script;
    
    // Start is called before the first frame update
    void Start()
    {
        rbd2D = GetComponent<Rigidbody2D>();
        GameObject joystickObject = GameObject.Find("Fixed Joystick");
        joy_script = joystickObject.GetComponent<FixedJoystick>();
    }

    // Update is called once per frame
    public void Update()
    {

        //Get joystick direction
        Vector2 movement = joy_script.Direction;

        // transform.Rotate(-Vector3.forward,  moveHorizontal * speed);
        rbd2D.AddForce(movement * speed);

    }

}