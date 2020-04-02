using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovementEnemy : MonoBehaviour
{
    //This will be a public integer to store how much damage a bulet does
    public int damageDealt = 30;

    //Getting other variables necessary
    public Rigidbody2D theRigidBody;
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
    }

    //Checking if the bullet hits the player and hurting the player
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            //Damaging the player
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageDealt);

            //Destroying the bullet
            Destroy(this.gameObject);
        }

        //Destroyign the bullet if it hits a wall
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
