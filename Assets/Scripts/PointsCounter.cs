using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public Text recordText;
    public int points;
    public int record;
    public Text counterText;
    void Start()
    {
       points=0;
        record=PlayerPrefs.GetInt("record");
        recordText.text=record.ToString();
    }

    


    public bool IsNewRecord()
    {
        return points>record;

    }

    public void UpdateRecord()
    {
        record=points;
        recordText.text=record.ToString();
        PlayerPrefs.SetInt("record",record);
    }

    public void ClearRecord()
    {
        record=0;
        recordText.text=record.ToString();
         PlayerPrefs.DeleteKey("record");

    }
   /* public int wyslij(int a)
    {
        int b;
        b= points;
        return b;
    }*/
}
