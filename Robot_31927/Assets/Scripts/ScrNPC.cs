using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrNPC : MonoBehaviour {
    public GameObject caixa;
    public Text lblTexto;
    public Image image;
    public bool contatoJogador = false;
    bool dialogoAtivo = false;
    public int falo = 0;

    public string[] falas;
    public int indiceFala = 0;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void exibirDialogo()
    {
        lblTexto.text = falas[indiceFala];
    }

	void Update () {
        if (falo == 2)
        {
            if (contatoJogador && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.UpArrow)))
            {
                if (dialogoAtivo == false)
                {
                    indiceFala = 7;
                    exibirDialogo();
                    caixa.SetActive(true);
                    dialogoAtivo = true;
                }
                else
                {
                    indiceFala++;
                    if (indiceFala < falas.Length)
                    {
                        exibirDialogo();
                    }
                    else
                    {
                        caixa.SetActive(false);
                        lblTexto.text = "";
                        dialogoAtivo = false;
                    }
                }
            }
        }
        if (falo == 1)
        {
            if (contatoJogador && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.UpArrow)))
            {
                if (dialogoAtivo == false)
                {
                    indiceFala = 3;
                    exibirDialogo();
                    caixa.SetActive(true);
                    dialogoAtivo = true;
                }
                else
                {
                    indiceFala++;
                    if (indiceFala < falas.Length - 3)
                    {
                        exibirDialogo();
                    }
                    else
                    {
                        caixa.SetActive(false);
                        lblTexto.text = "";
                        dialogoAtivo = false;
                    }
                }
            }
        }
        if(falo == 0)
        {
            if (contatoJogador && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.UpArrow)))
            {
                if (dialogoAtivo == false)
                {
                    indiceFala = 0;
                    exibirDialogo();
                    caixa.SetActive(true);
                    dialogoAtivo = true;
                }
                else
                {
                    indiceFala++;
                    if (indiceFala <falas.Length-6)
                    {
                        exibirDialogo();
                    }
                    else
                    {
                        caixa.SetActive(false);
                        lblTexto.text = "";
                        dialogoAtivo = false;
                        falo = 1;
                    }
                }
            }
            
           
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
