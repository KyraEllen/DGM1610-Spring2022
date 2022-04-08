using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;
    public int maxHP;
    public HealthBar healthBar;


    [Header ("Player Movement")]
    public float moveSpeed = 5f; //Speed at which the player will move
    private Rigidbody2D rb; //store the referenced 2D rigidbody
    private Vector2 movement; //Store the player's x,y position for movement 
    private Vector2 direction;
   
    [Header ("Player Combat")]
    public int damage; //Damage amount to enemy
    public float attackRange; //Range at which the player can attack
    public float attackRate;
    private float lastAttackTime;
    public LayerMask enemyLayer;

    [Header ("Inventory")]
    public int key;
    public int coins;
    public int gem;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 

       curHP = maxHP;
       healthBar.SetHealth(maxHP);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //For Left, Right Movement
        movement.y = Input.GetAxis("Vertical"); //For Up, Down Movement
   
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time - lastAttackTime >= attackRate)
                Attack();
        }
    }
    //Set number of calls per frame works best with physics
    void FixedUpdate()
    {
        //Apply physics and move the charater
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();

    }
    void UpdateDirection()

    {
        Vector2 vel = new Vector2(movement.x,movement.y); //vel stands for velocity

        if(vel.magnitude != 0)
        {
            direction = vel;
        }
        
        rb.velocity = vel * moveSpeed;
    }

   
    void Attack() //If you do not have public or private declared it is private by default
    {
        lastAttackTime = Time.time;
        //Raycast using the enemyLayer

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)//null means nothing
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }
     public void TakeDamage(int damage)
    {
        curHP -= damage; // is the same as curHP = curHp - damage
        // Updates the health bat by current HP
        healthBar.SetHealth(curHP);
        if(curHP <= 0)
        {
            Death(); //If there is only one line after an if statement technically you don't need brackets 
        }

    }
     public void Death()
    {
        Debug.Log("The player has gone west...");
    }
}
