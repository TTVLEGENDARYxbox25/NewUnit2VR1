using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    float xMovement;
    float yMovement;
    float speedX = 10;
    float speedY = 15;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal")*speedX;
        yMovement = Input.GetAxis("Vertical")*speedY;
        xMove = new Vector2(xMovement, yMovement);
        player.Translate(xMove * Time.deltaTime);
    }
}
