using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    public GameObject deathAnimation;
    public float deathTime =145f;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "bullet(Clone)")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameObject explosion = Instantiate(deathAnimation, gameObject.GetComponent<Transform>().position,gameObject.GetComponent<Transform>().rotation) as GameObject;
            Destroy(explosion,deathTime*Time.deltaTime);

        }
         
    }
}
