using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criar : MonoBehaviour
{
	public GameObject inimigo;
	
    // Start is called before the first frame update
    void Start()
    {
        
		//Instantiate(inimigo); //spawn
				
		//Instantiate (objetoOriginal, position, rotation);
		//Instantiate (bolinha);
		//Instantiate (bolinha);
		//Instantiate (bolinha);
		
		for (int contador = 0; contador < 5; contador++){
			
			//Vector3 pos = new Vector3(2f, 0.5f, 0f);
			
			float novoX = Random.RandomRange(-2f, 2f);
			
			float novoY = Random.RandomRange(0.5f, 2f);
			
			float rot = Random.RandomRange(15f, 145f);
			
			//Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward); // rotacionar em Z
			
			Vector3 pos = new Vector3(novoX + contador, novoY * contador, rot);
			
			
			Instantiate (inimigo, pos, Quaternion.identity);
			print("inimigo: " + contador);
		}
		
		print("finalizado o processo de criação de prefabs");
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
