using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHEBBossSCENESWITCHER : MonoBehaviour
{
    //these are the variable needed to switch to the scene
    public int CHEBSceneNumber = 0;
    public GameObject player;

    public void OnTriggerEnter2D(Collider2D theCollider)
    {
        //this will only load the final boss battle if the players year is 4th year
        if (theCollider.CompareTag("player") && player.GetComponent<PlayerMovement>().Level >= 4)
        {
            //loads the CHEBScene
            SceneManager.LoadScene(CHEBSceneNumber, LoadSceneMode.Single);
        }

    }

}
