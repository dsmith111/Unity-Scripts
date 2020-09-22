using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class blockEnemyAi : MonoBehaviour
{
    public float enemySpeed = 45f;
    PlayerController playerController;
    Rigidbody2D rbd2D;
    // Start is called before the first frame update
    void Start()
    {
        rbd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject player = GameObject.Find("Player");
        Transform playerTransform = player.GetComponent<Transform>();
        Vector2 playerPosition = playerTransform.position;
        Vector2 enemyPosition = rbd2D.position;
        Vector2 moveDir = playerPosition - enemyPosition;
        rbd2D.AddForce(moveDir.normalized * enemySpeed * Time.deltaTime);
    }
}
