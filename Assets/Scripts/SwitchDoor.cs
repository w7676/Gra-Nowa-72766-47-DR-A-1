using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDoor : MonoBehaviour
{
    public GameObject futryna;
    public string message;


    void OnTriggerEnter(Collider col)
    {
        futryna.SendMessage(message);


    }



}
