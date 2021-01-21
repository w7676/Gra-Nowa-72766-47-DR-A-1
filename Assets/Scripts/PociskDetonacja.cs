﻿using UnityEngine;
using System.Collections;

/**
 * Skrypt odpowiedzialny za zadanie obrażeń przez pocisk lecący np. rakieta.
 */
public class PociskDetonacja : MonoBehaviour {

	//Animacja przy uderzeniu
	public GameObject uderzeniePrefab;

	//Obrarzenie jakie zadaje (ile punktow zdrowia zabiera).
	public float obrazenia = 200f;
	//Zasieg eksplozji.
	public float zasiegEksplozji = 3f;


	void OnTriggerEnter(){
		Debug.Log ("OnTriggerEnter");
		Detonacja();
	}

	void Detonacja(){
		Vector3 punktDetonacji = transform.position ;
		
		if (uderzeniePrefab != null) {
			Instantiate(uderzeniePrefab, punktDetonacji, Quaternion.identity);
			
		}
		Destroy (gameObject);

		//Pobranie wszystkich obiektów w zasięgu pola rażenia pocisku.
		Collider[] colliders = Physics.OverlapSphere (punktDetonacji, zasiegEksplozji);
		//Iteracja w celu sprawdzenia czy obiekt znajdujący się w polu rażenia zawiera punkty zdrowia.
		foreach(Collider c in colliders){			
			Zdrowie h = c.GetComponent<Zdrowie>();
			if(h != null) {
				float dist = Vector3.Distance(punktDetonacji, c.transform.position);
				//Obliczenie obrażeń zgodnie z odstępem od pocisku. 
				//Im bliżej tym obrażenia większe im dalej tym mniejsze.
				float noweObrazenia = 1f - (dist / zasiegEksplozji); 
				h.otrzymaneObrazenia(obrazenia *  noweObrazenia);
			}
			
		}
	}
}
