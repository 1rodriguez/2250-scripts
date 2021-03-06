﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This will be used to move the bullet
public class BulletMovement : MonoBehaviour
{
    public int damageDealt = 30;

    //This rigidBody will be what the builder
    public Rigidbody2D theRigidBody;

    //The speed will control 
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Getting the RB component
        theRigidBody = GetComponent<Rigidbody2D>();
    }


    //This will actually move the bullet
    public void movement(Vector2 direction)
    {
        theRigidBody.velocity = direction.normalized * speed;
        Debug.Log("MOVINGS");
        Debug.Log(direction);
    }


    //Detecting the collision
    void OnTriggerEnter2D(Collider2D other)
    {
        //If the other tag is enemy then the function will hurt the enemy
        if (other.gameObject.CompareTag("enemy"))
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageDealt);
            Destroy(this.gameObject);
        }
        
        //Will destroy the bullet if it hits a wall
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(this.gameObject);
        }
    }

}
