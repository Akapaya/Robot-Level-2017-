using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrMorte : MonoBehaviour {
    public Transform checkpoint;
    //ScrNPC npc;
	// Use this for initialization
	void Start () {
        //npc = GetComponent<ScrNPC>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D quem)
    {
        //Destroy(quem.gameObject);
        quem.transform.position = checkpoint.position;
        //npc.falo = 2;
    }
}
