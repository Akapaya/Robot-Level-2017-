using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrBotão : MonoBehaviour {

    public GameObject porta;
    public bool ligado = false;
    public bool contatoJogador = false;

    public float tempoDesativa = 2f;
    public float tempoTranca = 10f;

    public Animator anim;
	// Use this for initialization
    void Desliga()
    {
        ligado = false;
        anim.SetBool("situacao", false);
    }
    void FechaPorta()
    {
        if (porta.GetComponent<ScrPorta>().contatoJogador == false)
        {
            porta.GetComponent<ScrPorta>().trancada = true;
            porta.GetComponent<Animator>().SetInteger("situacao", 0);
        }
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (contatoJogador && Input.GetKeyDown(KeyCode.E))
        {
            ligado = true;
            anim.SetBool("situacao", true);
            Invoke("Desliga", tempoDesativa);

            porta.GetComponent<ScrPorta>().trancada = false;
            porta.GetComponent<Animator>().SetInteger("situacao", 1);
            Invoke("FechaPorta",tempoTranca);
        }
	}
    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            contatoJogador = true;
        }
    }
    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            contatoJogador = false;
        }
    }
}
