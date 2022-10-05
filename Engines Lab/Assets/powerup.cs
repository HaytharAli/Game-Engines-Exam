using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PowerupManager.instance.triggerPowerUp();
            Debug.Log("Player Trigger");
        }
        if(collision.gameObject.tag == "bullet")
        {
            PowerupManager.instance.ChangePowerUp(2);
            Debug.Log("Bullet Trigger");
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                //Material>().color = Color.blue;
        }
    }
}
