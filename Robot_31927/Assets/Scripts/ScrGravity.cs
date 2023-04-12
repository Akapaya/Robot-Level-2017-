using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGravity : MonoBehaviour {
    public GameObject player;
    public GameObject[] setas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            player.GetComponent<ScrPlayer>().gravity = true;
            for (int i = 0; i <= 95; i++)
            {
                setas[i].GetComponent<ScrSetas>().Ligado = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            player.GetComponent<ScrPlayer>().gravity = false;
            for (int i = 0; i <= 95; i++)
            {
                setas[i].GetComponent<ScrSetas>().Ligado = false;
            }
        }
    }
}
