using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public bool isOpen=false;
    public float openPosition;
    public float closedPosition;
    public float smoothTime;
    float velocty;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newZ= Mathf.SmoothDamp( transform.position.z,openPosition,ref velocty,smoothTime);
        transform.position= new Vector3(transform.position.x,transform.position.y,newZ);

    }
}
