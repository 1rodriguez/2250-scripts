using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting1 : MonoBehaviour
{

    //This will call the current position
    private Transform currentPosition;
    new Vector3 currentDirection;

    //This will be used to store the o
    public GameObject myObject;


    // Start is called before the first frame update
    void Start()
    {
        //Repeatting the shooting ability starting after 2 sec, repeatting every 3 sec
        InvokeRepeating("Shooting", 2.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Getting wherer the palyer is
        currentPosition = GameObject.FindGameObjectWithTag("player").transform;
        currentDirection = currentPosition.position - transform.position;

    }


    //Shooting bullet method
    void Shooting()
    {
        //Looking at where the player is facing
        float direction = Mathf.Atan2(currentDirection.y, currentDirection.x);

        //Instantiating the object with regards to where the player is facing
        GameObject newObject = Instantiate(myObject, transform.position + currentDirection.normalized * 2, Quaternion.Euler(0f, 0f, direction));

        // Getting bullet movement for the enemy bullet
        BulletMovementEnemy movement = newObject.GetComponent<BulletMovementEnemy>();
        if (movement)
        {
            //Calling the movement method
            movement.movement(currentDirection);
        }



    }



}
