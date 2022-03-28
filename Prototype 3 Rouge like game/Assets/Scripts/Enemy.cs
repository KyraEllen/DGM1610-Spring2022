using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Health")]
    public int curHP;
    public int maxHP;
    [Header("Enemy Attack")]
    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    
    void Update()
    {
       if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
       {
           Attack();
       } 
    }
    
    
    public void TakeDamage(int damage)
    {
        curHP -= damage; // is the same as curHP = curHp - damage
        if(curHP <= 0)
        {
            Death(); //If there is only one line after an if statement technically you don't need brackets 
        }

    }
    void Attack()
    {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
