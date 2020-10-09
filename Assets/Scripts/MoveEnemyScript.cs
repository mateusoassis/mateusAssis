using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyScript : MonoBehaviour
{
	public Transform heroTransform;
	float speed = 3f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
		//pega posição relativa entre o heroi e o inimigo (distância)
		Vector3 relativePos = heroTransform.position - transform.position;
		
		//calcula o angulo formado pelos pontos da posição relativa
		float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
		
		//aplica o angulo na rotacao do transform
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		
		//altera a posicao do inimigo de acordo com a posicao do heroi
		transform.position = Vector2.Lerp(transform.position, heroTransform.position, Time.deltaTime*speed);
		
    }
}
