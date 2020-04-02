using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class energyScript : MonoBehaviour
{
    //Getting how much fill the energy bar shouldf have based on the playerenergy
    public float amountLeft = PlayerMovement.energy/100;
    public Image content;  

    // Update is called once per frame
    void Update()
    {
        //Setting the fill amount
        content.fillAmount = amountLeft;
        //Updating the fill amount
        updateAmountLeft();
    }

    //This will retrieve the player health to update the amount left for th next update
     void updateAmountLeft(){
         amountLeft  = PlayerMovement.energy/100;   
     }

}
