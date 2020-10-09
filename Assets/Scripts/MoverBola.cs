using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBola : MonoBehaviour
{
	
	
    float speed = 2f;

    //double: maior precisão (maior quantidade de casas decimais)
    //float: menor precisão (menor quantidade de casas decimais)
	
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1.0f, 1.0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 pos = transform.position;
		pos = transform.position + (speed * Time.deltaTime * Vector3.left);
		transform.position = pos;
		
		//transform.Translate(0.2f, 0.1f, 0f);
		
		
    }
}
