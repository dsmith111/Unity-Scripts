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
      /**  if (Input.GetKey(KeyCode.RightArrow))
         Physics2D. //(-Vector3.forward, turnSpeed * Time.deltaTime);
     if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);**/
        float moveHorizontal = Input.GetAxis("Horizontal");
       
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
       
        //Rotate to match direction
       
        if (Input.GetKey(KeyCode.W)==false &&Input.GetKey(KeyCode.S) == false)
        {
            if (Input.GetKey(KeyCode.D) == true) 
            {

                //rotSpeed += Time.deltaTime * speed;

                transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            else if (Input.GetKey(KeyCode.A) == true)
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            
        }
        else if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.S)==false)
        {
            if (Input.GetKey(KeyCode.D) == true)
            {

                //rotSpeed += Time.deltaTime * speed;

                transform.rotation = Quaternion.Euler(0, 0, -45);
            }
            else if (Input.GetKey(KeyCode.A) == true)
            {
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.S) ==true && Input.GetKey(KeyCode.W) == false)
        {
            if (Input.GetKey(KeyCode.D) == true)
            {

                //rotSpeed += Time.deltaTime * speed;

                transform.rotation = Quaternion.Euler(0, 0, -135);
            }
            else if (Input.GetKey(KeyCode.A) == true)
            {
                transform.rotation = Quaternion.Euler(0, 0, 135);
            }
            else if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
            {
                transform.rotation = Quaternion.Euler(0, 0, 180);
            }
        }

        // transform.Rotate(-Vector3.forward,  moveHorizontal * speed);
        rbd2D.AddForce(movement * speed);
        
    }

   }