using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/**
 * Skrypt zdrowia.
 * Jezeli obiekt ma ten skrypt to znaczy, że ma zdrowie ktore mozna mu zabrac.
 */
public class EneZdrowie : MonoBehaviour {

	//Punkty zdrowia.
	public int zdrowie = 100;
	public int maxZdrowie=100;

	public virtual void otrzymaneObrazenia(float obrazenia) {
		//Jeżeli zdrowie większe od zera to można zadać obrażenia.
		if (zdrowie > 0) {
			//Odięcie od zdrowia punktów zadanych obrażeń.
			zdrowie -= (int)obrazenia;

			if(zdrowie < 0){//Jeżeli zdrowie mniejsze od zera to nie chcemy aby było wyświetlane zdrowie na minusie.
				zdrowie = 0; //Mniejsze od zera to wyzeruj.
			}
		}

		//Jeżeli zdrowie równe zero to obiekt do usunięcia.
		if(zdrowie <=0){
			Die();
		}
	}

	/**
	 * Metoda powoduje usunięcie obiektu.
	 */
	public void Die(){
		Destroy(gameObject);	
	}

	/**
	 * Funkcja zwraca informację o tym czy obiekt posiadający zdrowie ciągle żyje.
	 * Jeżeli obiekt żyje to zwraca 'false' w przeciwnym razie 'true'.
	 */
	public bool czyMartwy(){
		if (zdrowie <= 0) {
			return true;
		}
		return false;
	}

}
	
	

