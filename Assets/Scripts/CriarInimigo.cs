using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarInimigo : MonoBehaviour
{
	public GameObject inimigo;
	public Transform hero;
	
	public int quantidade = 3;
	
    // Start is called before the first frame update
    void Start()
    {
        int contador;
		for (contador = 0; contador < quantidade; contador++){
			
			GameObject enemy = Instantiate (inimigo, new Vector3(5*contador + 1, 3.5f * contador, 0f), Quaternion.identity);
			enemy.GetComponent<MoveEnemyScript> ().heroTransform = hero;
			
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
