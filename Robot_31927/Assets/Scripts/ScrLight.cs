using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrLight : MonoBehaviour {
    public GameObject light;
    public Light luz;
    public float porcentagem = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
    void luz2()
    {
        luz.intensity += porcentagem;
    }
	
	// Update is called once per frame
	void Update () {
        luz2();
        if (luz.intensity >= 3)
        {
            porcentagem = -0.1f;
        }
        if (luz.intensity <= 0)
        {
            porcentagem = 0.1f;
        }
	}
}
