using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour {
    public Animator anim;
    public Rigidbody2D corpo;
    public Transform objpes;
    public GameObject tiro;
    public Transform Arma;

    float velocidade = 13f;
    int direcao = 1;
    public float eixoX;

    public LayerMask camadaChao;
    public bool nochao;
    float raioPosPes = 0.14f;

    public float forcaPulo = 30f;
    public bool Controlenoar;

    public bool gravity = false;
    public bool mola = false;
    public float forcamola = 1;
    public float forcaTiro = 50f;

    public GameObject camera1;
    public GameObject camera2;
    public GameObject cena1;
    public GameObject Interação;
    

    
    public Transform checkpoint;

    public void gravity2()
    {
        if (gravity == false)
        {
            corpo.gravityScale = 5;
            transform.localScale = new Vector3(direcao,1, 1);
        }
        if (gravity == true)
        {
            corpo.gravityScale = -3;
            transform.localScale = new Vector3(direcao, -1, 1);
        }
    }
    public void verificaDirecao()
    {
        if (eixoX > 0)
        {
            direcao = 1;
        }
        else
        {
            if (eixoX < 0)
            {
                direcao = -1;
            }
        }
        transform.localScale = new Vector3(direcao, 1, 1);
    }
    public void verificaAnimacao()
    {
        if (!nochao)
        {
            anim.SetInteger("situacao", 2);
        }
        else
        {
            if (eixoX == 0)
            {
                anim.SetInteger("situacao", 0);
            }
            if (Mathf.Abs(eixoX) != 0)
            {
                anim.SetInteger("situacao", 1);
            }
        }
    }
    public void movimento()
    {
        verificaDirecao();
        verificaAnimacao();
        if (nochao || Controlenoar)
        {
            corpo.velocity = new Vector2(eixoX * velocidade, corpo.velocity.y);
        }
    }
    void verificasequerpular()
    {
        if (gravity == false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                if (nochao)
                {
                    corpo.AddForce(new Vector2(0f, forcaPulo), ForceMode2D.Impulse);
                }
            }
        }
        if (gravity == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                if (nochao)
                {
                    corpo.AddForce(new Vector2(0f, -forcaPulo), ForceMode2D.Impulse);
                }
            }
        }
        //if (mola == true)
        //{
        //    corpo.AddForce(new Vector2(0f, forçamola), ForceMode2D.Impulse);
        //}
    }
    void Bala()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            velocidade = 0f;
            anim.SetInteger("situacao", 3);
            
        }
    }
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        eixoX = Input.GetAxis("Horizontal");

        nochao = Physics2D.OverlapCircle(new Vector2(objpes.position.x, objpes.position.y),raioPosPes, camadaChao);
        movimento();
        verificasequerpular();
        gravity2();
        Bala();
        atirar();
        cheat();
    }
    
    void OnCollisionEnter2D(Collision2D quem)
    {
        if (quem.transform.tag == "MovingPlat")
        {
            transform.parent = quem.transform;
        }    
    }
    void OnCollisionExit2D(Collision2D quem)
    {
        if (quem.transform.tag == "MovingPlat")
        {
            transform.parent = null;
        }
    }

    void atirar()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.SetInteger("situacao", 4);
            GameObject tiro2 = Instantiate(tiro, new Vector2(Arma.position.x, Arma.position.y), Quaternion.identity) as GameObject;
            tiro2.GetComponent<Rigidbody2D>().AddForce(new Vector2(direcao * forcaTiro, 0f), ForceMode2D.Impulse);
            velocidade = 13f;
        }
    }
    void cheat()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = checkpoint.position;
            camera1.SetActive(false);
            camera2.SetActive(true);
            Destroy(cena1);
        }
    }

    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Interação")
        {
            Interação.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Interação")
        {
            Interação.SetActive(false);
        }
    }
}
