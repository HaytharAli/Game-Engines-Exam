using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    CommandAbstract[] commands = new CommandAbstract[100];
    GlobalJump jumpcommand;

    private void Start()
    {
        commands[0] = jumpcommand;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            commands[0].execute();
        }
    }
}
