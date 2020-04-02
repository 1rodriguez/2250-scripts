using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour
{

    //Variables to store the starting and current health of the palyer
    public int playerMaxHealth;
    public int playerCurrentHealth;
    private int _sceneIdentifier = 3;

    //Setting the inital health of the player
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    //Setting the player to active false if the player has no health left
    void Update()
    {
        if (playerCurrentHealth <= 0)
        {
            this.gameObject.SetActive(false); // Inactivity instead of destruction avoids problems with PlayerMovement script checking the Object transform
            SceneManager.LoadScene(_sceneIdentifier, LoadSceneMode.Single);
        }
    }

    //Damaging the player
    public void HurtPlayer(int dmg)
    {
        playerCurrentHealth -= dmg;

    }

    //Setting the initial health of the palyer
    public void SetMaxHealth(int max)
    {
        playerMaxHealth = max;
    }

}
