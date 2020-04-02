using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This will serve as the script to drive the Melee of the player
public class MeleeAbility : MonoBehaviour
{

    //Variables to store the enmies and player/playerposition
    public GameObject myObject;
    public float radius;
    public Transform currentPosition;
    public LayerMask enemy;

    void Update(){

        if(Input.GetButtonDown("MeleeAbility")){

            //Getting the list of active enemies
            Collider2D[] listOfEnemies = Physics2D.OverlapCircleAll(currentPosition.position, radius, enemy );
            
            //If there are enemies in the list, then it will damage all enemies in the circle
            if(listOfEnemies.Length>0){
                for (int i = 0; i < listOfEnemies.Length; i++){listOfEnemies[i].GetComponent<EnemyHealthManager>().enemyCurrentHealth -=10;}
            }  
        }
    }

    //Drawing the circle in red
    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;    
        Gizmos.DrawWireSphere(currentPosition.position, radius);
    }

}
