using UnityEngine;
using System.Collections;

/**
 * Skrypt zdrowia.
 * Jezeli obiekt ma ten skrypt to znaczy, że ma zdrowie ktore mozna mu zabrac.
 */
public class EneZdrowie : MonoBehaviour {

	//Punkty zdrowia.
	public float zdrowie;
	public float maxZdrowie;
	
	//Zadanie obrażeń.
	public void otrzymaneObrazenia(float obrazenia) {
		//Odięcie od zdrowia punktów zadanych obrażeń.
		zdrowie -= obrazenia;
		//Jeżeli zdrowie równe zero to obiekt do usunięcia.
		/*if(zdrowie <=0){
			Die();
		}	*/
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
        
    }



}

