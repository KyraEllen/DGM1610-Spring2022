using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; //Speed at which the player will move
    private Rigidbody2D rb; //store the referenced 2D rigidbody

    Vector2 movement; //Store the player's x,y position for movement

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontl"); //For Left, Right Movement
        movement.y = Input.GetAxis("Vertical"); //For Up, Down Movement
    }
    //Set number of calls per frame works best with physics
    void FixedUpdate()
    {
        //Apply physics and move the charater
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
