using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineDetector : MonoBehaviour
{
    //Animator Attached to the mine
    private Animator _mineAnimator;

    //Getting the mine animator
    void Start()
    { _mineAnimator = GetComponent<Animator>(); }



    //This will detect the collidor
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            //Damaging the player
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(10);

            //Playing the animation
            _mineAnimator.Play("explosion");

            //Delay the destroy function for 0.3s
            Destroy(this.gameObject, 0.3f);

        }

        //If it hits a wall, it also destroys
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(this.gameObject);
        }
    }

}
