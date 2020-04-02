using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderAnimation : MonoBehaviour
{
    //These are all of the variables that need to be initailized
    //this is the animator that will take care of the transition
    public Animator transition;
    //this will be the sceneNumber that it switches to
    public int sceneNumber;
    //this is the time taken for transition
    public float transitionTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //this will ocur when the trigger is hit
    public void OnTriggerEnter2D(Collider2D theCollider)
    {
        //will load the next scene
        LoadNextLevel();


    }
    //this is incharge of loading the next scene
    public void LoadNextLevel()
    {
        //This starts a coroutine that loads the next scene based on the scene number
        StartCoroutine(LoadLevel(sceneNumber));
    }

    //this is incharge of loading the next level
    IEnumerator LoadLevel(int levelIndex)
    {
        //sets the transition and starts the new level using a corountine so that it doesnt interupt other code
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);



    }

    
}
