/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using System;
using UnityEngine;
using System.Collections;
 
/**
 * When creating your message listeners you need to implement these two methods:
 *  - OnMessageArrived
 *  - OnConnectionEvent
 */

public class SampleMessageListener : MonoBehaviour
{
    GameObject PlayerObject;
    private bool Sucess; 
    private float ComboSucess;

    private float MoveSpeed;
    private void Start()
    {
        PlayerObject= GameObject.FindWithTag("Player");
    }

    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        //This is to show, what would have been done if hardware had worked 
        Sucess = bool.Parse(msg);
        ComboSucess = float.Parse(msg);

        if (Sucess)
        {
            switch (ComboSucess)
            {
                case 0:
                    //Moving
                    PlayerObject.gameObject.transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
                    break;
                case 1:
                    //Attack
                    PlayerObject.gameObject.transform.Translate(Vector3.up * Time.deltaTime * MoveSpeed);
                    break;
                case 2:
                    //Retreat
                    PlayerObject.gameObject.transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
                    break;
            }
        }
        Debug.Log("Message arrived: " + msg);
    }

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }
}
