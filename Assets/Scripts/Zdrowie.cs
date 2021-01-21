using UnityEngine;
using System.Collections;

/**
 * Skrypt zdrowia.
 * Jezeli obiekt ma ten skrypt to znaczy, że ma zdrowie ktore mozna mu zabrac.
 */
public class Zdrowie : MonoBehaviour {

	//Punkty zdrowia.
	public float zdrowie = 100.0f;
	public float maxZdrowie = 100.0f;
	
	//Zadanie obrażeń.
	public void otrzymaneObrazenia(float obrazenia) {
		//Odięcie od zdrowia punktów zadanych obrażeń.
		zdrowie -= obrazenia;
		//Jeżeli zdrowie równe zero to obiekt do usunięcia.
		/*if(zdrowie <=0){
			Die();
		}*/	
	}
	
	public void Die(){
		Destroy(gameObject);	
	}

	public bool czyMartwy(){
		if (zdrowie <= 0) {
			return true;
		}
		return false;
	}

	void Start()
    {
        zdrowie = 100.0f;
		maxZdrowie = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
		if(zdrowie < maxZdrowie)
		{
			zdrowie ++;
		}
        
    }

	void OnGUI()
	{

		GUI.Box(new Rect(10,Screen.height-50,150,40),"Zdrowie :"+zdrowie+"/"+maxZdrowie);
	}


}
