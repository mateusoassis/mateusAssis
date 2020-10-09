using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CestaOuRede : MonoBehaviour
{
	//public int score;
	//public int total_score;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "aro") {
			
		print("Você acertou o aro! +2 pontos!");
		//score += 2;
		//total_score += score;
        //print("Seu placar total é de: " + score);

		Destroy(this.gameObject, 0);
		
		}
		
		if (col.gameObject.tag == "rede"){
			
		print("Você acertou a rede! +1 ponto!");
		//score += 1;
		//total_score += score;
		//print("Seu placar total é de: " + score);

		Destroy(this.gameObject, 0);
		
		}
	
	
	}
	
}
