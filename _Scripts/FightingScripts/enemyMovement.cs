using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : StateMachineBehaviour
{
    //This will represent the player position
    private Transform _currentPosition;
    public float speed;
    private Animator animationVariable;
    private Vector2 movement;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        //Finding the psoition of the player using its tag
        _currentPosition = GameObject.FindGameObjectWithTag("player").transform;

        //Setting the animation variable of the enemy based on whats passed through the funciton
        animationVariable = animator;
    }


    //Acts as the update function
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Finding the object in the game caleld the "Player Variant" and moving towards it
        if (GameObject.Find("Player Variant"))
        {
            //Moving the enemy towards the current position of the player
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, _currentPosition.position, speed * Time.deltaTime);
        }
        
        //Setting the vector2 to the position of 
        movement = _currentPosition.position;

        //Note: had to normalize the variables since the numbers didnt work great with the animator
        animationVariable.SetFloat("horizontalMovement", (movement.normalized.x));
        animationVariable.SetFloat("verticalMovement", (movement.normalized.y));
    }


    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Setting the animation once it exits the state
        animationVariable.SetFloat("horizontalMovement", (movement.normalized.x));
        animationVariable.SetFloat("verticalMovement", (movement.normalized.y));
    }
}
