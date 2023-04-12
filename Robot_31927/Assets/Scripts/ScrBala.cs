using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrBala : MonoBehaviour {
    public Renderer render;
    public GameObject Explosão;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (render.isVisible == false)
        {
            Destroy(gameObject);
        }
	}
    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Inimigo")
        {
            GameObject ExploON = Instantiate(Explosão, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject;
            Destroy(quem.gameObject);
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D quem)
    {
        
        if (quem.gameObject.tag != "Player")
        {
            GameObject ExploON = Instantiate(Explosão, new Vector2(transform.position.x, transform.position.y), Quaternion.identity) as GameObject;
            Destroy(gameObject);
        }
        
    }
}
