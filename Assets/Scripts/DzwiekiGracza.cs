using UnityEngine;
using System.Collections;

/*
* Skrypt odpowiedzialny za odtwarzanie dzwięków poruszania gracza.
* 
* 
 */
public class DzwiekiGracza : MonoBehaviour {

	//Obiekt odpowiedzialny za ruch gracza.
	public CharacterController characterControler;

	/** Źródło dzwięki.*/
	public AudioSource zrodloDzwieku;
	/** Dzwięk chodzenia.*/
	public AudioClip dzwiechodzenie;
	/** Dzwięk skoku.*/
	public AudioClip dzwiekSkoku;
	/** Dzwięk lądowania.*/
	public AudioClip dzwiekLadowania;
	/** Licznik do następnego odtwarzania.*/
	public float odliczanieDoKroku = 0f;
	/** Co ile ma być odtwarzany dzwięk kroku.*/
	public float czasKroku = 0.5f;

	/**Zmienna z informacją o tym czy gracz dalej chodzi po ziemi czy podskoczył.*/
	public bool graczNaZiemi;

	/** Component gracza odpowiedzialny za poruszanie.*/
	private PlayerControler playerControler;

	// Use this for initialization
	void Start () {
		playerControler = GetComponent<PlayerControler> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (zrodloDzwieku != null) {//Jeżeli źródło dzwięku nie zostało podpięte to i tak nie ma co odgrywać.
			dzwiekChodzenia ();
		}

	}

	/**
	 * Metoda odpowiedzialna za oddtwarzanie dzwięku chodzenia gracza.
	 */
	private void dzwiekChodzenia(){
		//Zmniejszanie licznika do kolejnego odtworzenia dźwięku.
		if (odliczanieDoKroku > 0) {
			//Sprawdzenie, jeżeli gracz biegnie to dźwięk kroku będzie odtwarzany szybciej.
			if (playerControler.czyGraczBiegnie()) {
				odliczanieDoKroku -= Time.deltaTime * 1.3f;
			} else {
				odliczanieDoKroku -= Time.deltaTime;
			}
		}

		//Jeżeli gracz się porusza to odgrywaj dzwięk poruszania.
		if (playerControler.czyGraczChodzi () && characterControler.isGrounded && odliczanieDoKroku <= 0) {
			odliczanieDoKroku = czasKroku;
			zrodloDzwieku.PlayOneShot (dzwiechodzenie);
		}
		//Jeżeli gracz podskoczył i znajduje się na ziemi to odegraj dzwięk skoku.
		if (Input.GetButton ("Jump") && graczNaZiemi) {
			zrodloDzwieku.PlayOneShot (dzwiekSkoku);
		}
		//Jeżeli gracz ostatnio był w powietrzu a teraz na ziemi to znaczy, że wylondował na ziemi
		//zatem odegraj dzwięk londowania.
		if(!graczNaZiemi && characterControler.isGrounded) {				
			zrodloDzwieku.PlayOneShot (dzwiekLadowania);				
		}
		//Na zakończenie sprawdzamy czy gracz ciągle chodzi po ziemi.
		graczNaZiemi = characterControler.isGrounded;
	}
}
