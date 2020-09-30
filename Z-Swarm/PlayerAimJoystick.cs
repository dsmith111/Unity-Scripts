using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAimJoystick : MonoBehaviour
{
    public float speed = 95f;
    public FixedJoystick joy_script;
    public Transform cursor_shoot_Transform;
    public Transform player_Transform;

    // Start is called before the first frame update
    void Start()
    {
        GameObject joystickObject = GameObject.Find("Fixed Aim Joystick");
        GameObject cursorShootObject = GameObject.Find("Cursor_Shoot");
        GameObject playerObject = GameObject.FindWithTag("Player");

        joy_script = joystickObject.GetComponent<FixedJoystick>();
        cursor_shoot_Transform = cursorShootObject.GetComponent<Transform>();
        player_Transform = playerObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    public void Update()
    {

        //Get joystick direction
        Vector2 aim = joy_script.Direction;
        Vector2 player_pos = player_Transform.transform.position;
        // Update Reticle Position
        cursor_shoot_Transform.transform.position = player_pos + aim;
                
    }

}