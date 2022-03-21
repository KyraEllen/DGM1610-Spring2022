using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;
    public int maxHP;

    [Header ("Player Movement")]
    public float moveSpeed = 5f; //Speed at which the player will move
    private Rigidbody2D rb; //store the referenced 2D rigidbody

    Vector2 movement; //Store the player's x,y position for movement
    [Header ("Player Combat")]
    public float attackRange; //Range at which the player can attack
    public attackRate;
    private float last attackTime;
    public int damage; //Damage amount to enemy
    public LayerMask enemyLayer;


    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //For Left, Right Movement
        movement.y = Input.GetAxis("Vertical"); //For Up, Down Movement
    }
    //Set number of calls per frame works best with physics
    void FixedUpdate()
    {
        //Apply physics and move the charater
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

    void Attack()//If you do not have public or private declared it is private by default
    {
        lastAttackTime = Time.time;
        //Raycast using the enemyLayer

        RaycastHit2D hit = Physics2D.Raycast(transform.position, facingDirection, attackRange, enemyLayer);

        if(hit.collider != null)//null means nothing
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }
     public void Death()
    {
        Debug.Log("The player has gone west...");
    }
}
