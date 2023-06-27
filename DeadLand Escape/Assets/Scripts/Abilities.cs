using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
Ability ideas:

-Upgrade gun Fire rate
-Upgrade movement speed

 */



public class Abilities : MonoBehaviour
{

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            heal();
        }
    }


    public void heal()
    {
        if (PlayerHealth.currentHealth < 100 && Coin.Coins > 4)
        {
            PlayerHealth.currentHealth += 5;
            Coin.Coins -= 5;
        }
    }

    public void addFireRate()
    {

    }

}