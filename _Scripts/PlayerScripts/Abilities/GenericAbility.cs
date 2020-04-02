using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//References for objects
[CreateAssetMenu(menuName ="Scripts/Abilities/GenericAbility", fileName = "New Generic Ability")]


//Creating the generic ability class as a ScriptableObject in order to have stand-alone serialization
//This will hold more static information
public class GenericAbility : ScriptableObject
{
    //Virtual in order to be overriden
    public virtual void Ability(Vector2 playerPosition, Vector2 currentDirection, Animator playerAnimator, Rigidbody2D playerRB = null){} 

}

