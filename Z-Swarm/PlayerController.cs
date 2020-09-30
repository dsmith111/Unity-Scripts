using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 95f;
    
    public Rigidbody2D rbd2D;
    // Start is called before the first frame update
    void Start()
     {
        rbd2D = GetComponent<Rigidbody2D>();
     }

    // Update is called once per frame
    public void Update()
    {

        //   Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Rotate to match direction
        Vector2 movement = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W)==false &&Input.GetKey(KeyCode.S) == false)
        {
            if (Input.GetKey(KeyCode.D) == true) 
            {

                //   transform.rotation = Quaternion.Euler(0, 0, -90);
                movement = new Vector2(1,0);
            }
            else if (Input.GetKey(KeyCode.A) == true)
            {
                //   transform.rotation = Quaternion.Euler(0, 0, 90);
                movement = new Vector2(-1, 0);
            }
            
        }
        else if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.S)==false)
        {
            if (Input.GetKey(KeyCode.D) == true)
            {

                //rotSpeed += Time.deltaTime * speed;
                movement = new Vector2(1, 1);
                //   transform.rotation = Quaternion.Euler(0, 0, -45);
            }
            else if (Input.GetKey(KeyCode.A) == true)
            {
                movement = new Vector2(-1, 1);
                //   transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
            {
                movement = new Vector2(0, 1);
                //   transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.S) ==true && Input.GetKey(KeyCode.W) == false)
        {
            if (Input.GetKey(KeyCode.D) == true)
            {
                movement = new Vector2(1, -1);

                //rotSpeed += Time.deltaTime * speed;

                //   transform.rotation = Quaternion.Euler(0, 0, -135);
            }
            else if (Input.GetKey(KeyCode.A) == true)
            {
                movement = new Vector2(-1, -1);
                //   transform.rotation = Quaternion.Euler(0, 0, 135);
            }
            else if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
            {
                movement = new Vector2(0, -1);
                //   transform.rotation = Quaternion.Euler(0, 0, 180);
            }
        }

        // transform.Rotate(-Vector3.forward,  moveHorizontal * speed);
        rbd2D.AddForce(movement * speed);
        
    }

   }