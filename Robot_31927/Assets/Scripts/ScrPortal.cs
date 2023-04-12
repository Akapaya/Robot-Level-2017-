using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPortal : MonoBehaviour {
    public Transform portal1;
    public Transform portal2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	     	
	}
    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Portal1")
        {
            transform.position = portal2.transform.position;
        }
        if (quem.gameObject.tag == "Portal2")
        {
            transform.position = portal1.transform.position;
        }
    }
}
