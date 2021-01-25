using UnityEngine;
using System.Collections;

public class StrzalKamieniem : MonoBehaviour {

	//Obiekt kamienia.
	public GameObject kamienPrefab;
	public float predkosc = 50;
	/** Źródło dzwięki.*/
	public AudioSource zrodloDzwieku;
	/** Dzwięk strzału.*/
	public AudioClip odglosStrzalu;

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){ //Jezeli nacisniety przycisk fire
						
			GameObject kamien;
			//Utworzenie instatncji poocisku i nadanie mu pozycji kamery.
			kamien = (GameObject) Instantiate(kamienPrefab, Camera.main.transform.position+Camera.main.transform.forward, Camera.main.transform.rotation);
			kamien.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * predkosc, ForceMode.Impulse);
		    if(zrodloDzwieku != null) {//Na wszelki wypadek jak by nie zostało podpięte źródło dzwięku.
				zrodloDzwieku.PlayOneShot(odglosStrzalu);
			}
		
		}
	}

}