using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController2 : MonoBehaviour
{

    public bool isOpen=false;
    public float openPosition;
    public float closedPosition;
    public float target;
    public float smoothTime;
    float velocty;
    public GameObject doorObject;




    // Start is called before the first frame update
    void Start()
    {
        target=closedPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float newX= Mathf.SmoothDamp( doorObject.transform.localPosition.x,target,ref velocty,smoothTime);
        doorObject.transform.localPosition= new Vector3(newX,doorObject.transform.localPosition.y,doorObject.transform.localPosition.z);

    }


    public void OpenDoor()
    {
        target= openPosition;
        isOpen=true;

    }

    public void CloseDoor()
    {
        target=closedPosition;
        isOpen=false;

    }


}
