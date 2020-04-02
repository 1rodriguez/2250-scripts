using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{
    //variable that correlates to which scene to switch to
    public int myScene;

    public void OnTriggerEnter2D(Collider2D theCollider)
    {
        //only switches to scene if the object that triggers the collision event is tagged as the player
        if (theCollider.CompareTag("player"))
        {
            //this will load the new scene
            SceneManager.LoadScene(myScene, LoadSceneMode.Single);
        }
       
      



    }




}
