using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPorta : MonoBehaviour {
    public bool trancada = true;
    public bool contatoJogador = false;
    public Animator anim;
    public Transform fase;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject player;
    public GameObject cena1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cena();
	}
    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            contatoJogador = true;
            
            anim.SetInteger("situacao", 2);
        }
    }
    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            contatoJogador = false;
            Invoke("teste2", 1f);
            anim.SetInteger("situacao", 3);
        }
    }
    void teste()
    {
        if (trancada == false)
        {
            anim.SetInteger("situacao", 1);
        }
    }
    void teste2()
    {
        if (contatoJogador == false)
        {
            trancada = true;
            anim.SetInteger("situacao", 0);
        }
    }

    void cena()
    {
        if (Input.GetKeyDown(KeyCode.E) && trancada == false && contatoJogador == true)
        {
            player.transform.position = fase.position;
            camera1.SetActive(false);
            camera2.SetActive(true);
            Destroy(cena1);
        }
    }
}
