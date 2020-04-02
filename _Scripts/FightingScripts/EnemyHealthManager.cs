using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{

    //Variables to store the player object along with teh starting and current enemy health
    public GameObject player;
    public int enemyMaxHealth;
    public int enemyCurrentHealth;


    //Initializing the starting health of the enemy
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

    //Update method to see if the player has killed the object
    void Update()
    {

        //If the enemy health is less than 0 it will destro the current Enemy and give experience to the player
        if (enemyCurrentHealth <= 0)
        {
            //Giving the player experience
            player.GetComponent<PlayerMovement>().Experience = 1000;

            //Destroying the game object
            Destroy(gameObject);
        }
        
    }


    //Method to hurt the enemy
    public void HurtEnemy(int dmg)
    {
        enemyCurrentHealth -= dmg;

    }

    //Method to set the starting health of the enemy
    public void SetMaxHealth(int max)
    {
        enemyMaxHealth = max;
    }



}
