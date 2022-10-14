using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour
{
    int health;
    Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        player = null;
        Debug.Log("Health: " + health);
        Debug.Log("Player is here: " + player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
