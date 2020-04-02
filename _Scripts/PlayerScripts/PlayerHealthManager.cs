using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour
{
    public int playerMaxHealth;
    public int playerCurrentHealth;
    private int _sceneIdentifier = 3;
    // Start is called before the first frame update

    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }
    void Update()
    {
        if (playerCurrentHealth <= 0)
        {
            this.gameObject.SetActive(false); // Inactivity instead of destruction avoids problems with PlayerMovement script checking the Object transform
            SceneManager.LoadScene(_sceneIdentifier, LoadSceneMode.Single);
        }
    }

    public void HurtPlayer(int dmg)
    {
        playerCurrentHealth -= dmg;

    }

    public void SetMaxHealth(int max)
    {
        playerMaxHealth = max;
    }

}
