using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDaleDaleDale : MonoBehaviour
{
	public int score;
	public int total_score;
    // Start is called before the first frame update
    void Start()
    {
        total_score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        print("Sua pontuação total é: "+ total_score);    }
}
