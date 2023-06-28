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
<<<<<<< HEAD
    public Shooting shooting;


    int fireRateLevel = 0;
    int fireRateUpgradeCost = 10;
=======
>>>>>>> parent of db71410 (Added ability to upgrade fire rate)

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


    public void buyAbility(string ability)
    {
        switch (ability) 
        {
            default:
            case "addFireRate":
                addFireRate();
                Debug.Log("added fire rate");
                break;
        }
    }
}