using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletClone;
    public Transform playerLauncher;
    public float bulletSpeed =45500f;
    readonly PlayerController playerController;
    Rigidbody2D rb2D;
    int bulletDelayCount;
    public int bulletDelayMax;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
       bulletDelayCount = 0;
        bulletDelayMax = 10;
        animator.SetBool("Firing", false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        switch (bulletDelayCount) { 
            case 0: 
                if (Input.GetKey(KeyCode.Space) == true) {
                    // Vector2 playerVector = new Vector2 (Mathf.Abs(rb2D.velocity.x),Mathf.Abs(rb2D.velocity.y));
                    Vector2 playerVector = rb2D.velocity;
                    GameObject firedBullet;
                    firedBullet = Instantiate(bulletClone, playerLauncher.position, playerLauncher.rotation) as GameObject;
                    firedBullet.GetComponent<Rigidbody2D>().AddForce((playerLauncher.up * bulletSpeed * Time.deltaTime));

                   // firedBullet.GetComponent<Rigidbody2D>().velocity += (playerVector);
                    bulletDelayCount = bulletDelayMax;
                    Destroy(firedBullet, 1f);
                    animator.SetBool("Firing", true);

        } break;
            default :
        bulletDelayCount--;
                animator.SetBool("Firing", false); break;
    }
    }
    }

