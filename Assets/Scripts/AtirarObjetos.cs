using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarObjetos : MonoBehaviour
{
	public Rigidbody2D projectile;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
			
			Rigidbody2D clone;
			Vector3 pos = new Vector3(-8f, -1f,0);
			
			clone = Instantiate (projectile, pos, Quaternion.identity) as Rigidbody2D;
			
			clone.mass = Random.Range(0.01f, 1.0f);
			clone.velocity = clone.transform.TransformDirection(Random.Range(3.0f, 10.0f), Random.Range(8f, 14f), 0f);
			
				Destroy(clone.gameObject, 5.0f);
			
			
		}
    }
}
