using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrMola : MonoBehaviour {
    float impulso = 36f;
    public GameObject player;
    public Animator anim;

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
            anim.SetInteger("situacao", 1);
            //player.GetComponent<ScrPlayer>().corpo.AddForce(new Vector2(0f, impulso), ForceMode2D.Impulse);
        }
    }
    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            //player.GetComponent<ScrPlayer>().corpo.AddForce(new Vector2(0f, impulso), ForceMode2D.Impulse);
        }
    }
    void teste()
    {
        anim.SetInteger("situacao", 0);
    }

}
