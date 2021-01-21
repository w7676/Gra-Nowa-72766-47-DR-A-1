using UnityEngine;
using System.Collections;

/**
 * Skrypt odpowiedzialny za zadanie obrażen obiektowi z którym koliduje 
 * obiekt zawierający dany skrypt.
 */
public class EneObrazenia : MonoBehaviour {

	public float obrazenia = 20f;

	/**
	 * Metoda wywoływana w chwili nastąpienia kolizji z obiketem.
	 */
	void OnCollisionEnter(Collision kontakt ){    
		GameObject go = kontakt.gameObject;
		EneZdrowie zdrowie = (EneZdrowie) go.GetComponent<EneZdrowie>();
		if (zdrowie != null) {
			zdrowie.otrzymaneObrazenia(obrazenia);
		}
	}


}
