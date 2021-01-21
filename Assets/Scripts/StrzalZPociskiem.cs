using UnityEngine;
using System.Collections;

/*
* Skrypt odpowiedzialny za oddawanie strzalu z animacją/lotem pocisku.
*/
public class StrzalZPociskiem : MonoBehaviour {

	//Co ile mozna wykonac strzal
	public float czekaj = 1f;
	//Odliczanie do kolejnego strzalu.
	public float odliczanieDoStrzalu = 0f;
	//Obiekt pocisku.
	public GameObject pociskPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Zmniejszanie licznika do kolejnego strzalu/odliczanie do strzalu.
		odliczanieDoStrzalu -= Time.deltaTime;
		
		//Strzal nastepuje jezeli przycisk myszy jest ciagle wcisniety oraz jezeli odliczanie
		//do kolejnego strzalu jest rowne zero(mozna strzelac).
		if(Input.GetMouseButton(1) && odliczanieDoStrzalu <= 0){
			//Strzal zostal oddany ustawienie ponownego odliczania.
			odliczanieDoStrzalu = czekaj;
			
			//Wystrzelenie rakiety (projectilePrefab) z pozycji kamery oraz jej zwrocie/obrocie (rotation)
			//Poniewaz pocisk jest durzy to aby uniknac kolizji z samym soba jest dodany dodatkowa odleglosc (Camera.main.transform.forward)
			Instantiate(pociskPrefab, Camera.main.transform.position+Camera.main.transform.forward, Camera.main.transform.rotation);
			
			
		}
	}
}
