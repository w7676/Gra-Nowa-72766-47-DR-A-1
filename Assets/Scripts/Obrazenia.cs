using UnityEngine;
using System.Collections;

/**
 * Skrypt odpowiedzialny za zadanie obrażen obiektowi z którym koliduje 
 * obiekt zawierający dany skrypt.
 */
public class Obrazenia : MonoBehaviour {

	public float obrazenia = 20f;

	/**
	 * Metoda wywoływana w chwili nastąpienia kolizji z obiketem.
	 */
	void OnCollisionEnter(Collision kontakt ){    
		GameObject go = kontakt.gameObject;
		Zdrowie zdrowie = (Zdrowie) go.GetComponent<Zdrowie>();
		if (zdrowie != null) {
			zdrowie.otrzymaneObrazenia(obrazenia);
		}
	}


}
