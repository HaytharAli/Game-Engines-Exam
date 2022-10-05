using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    public static PowerupManager instance;
    public Player player;
    int number = 1;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangePowerUp(int num)
    {
        number = num;
    }

    public void triggerPowerUp()
    {
        if (number == 1)
        {
            player.doubleShot = true;
        }
        if (number == 2)
        {
            player.moveMul += 1;
        }
    }
}
