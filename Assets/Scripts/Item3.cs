using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class Item3 : MonoBehaviour
{
    
    public AudioClip pickupClip;
    public PointsCounter counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        AudioSource.PlayClipAtPoint(pickupClip, transform.position);
        counter.points += 10;
        if(counter.IsNewRecord())
        {
            counter.UpdateRecord();
        }
        counter.counterText.text = counter.points.ToString();
        Destroy(this.gameObject);
    }
        
        
        
        }
