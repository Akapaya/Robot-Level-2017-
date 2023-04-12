using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrAlien : MonoBehaviour {
    int direcao = 1;
    float LimIni;
    float LimFinal;
    public float velocidade;
    public float distancia;
    float posX;
    public Transform checkpoint;
    // Use this for initialization
    void Start()
    {
        posX = transform.position.x;
        LimIni = posX;
        LimFinal = posX + distancia;



    }

    // Update is called once per frame
    void Update()
    {
        posX += direcao * velocidade * Time.deltaTime;
        posX = Mathf.Clamp(posX, LimIni, LimFinal);
        if ((posX >= LimFinal) || (posX <= LimIni))
        {
            direcao *= -1;
        }
        transform.position = new Vector2(posX, transform.position.y);
    }
    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            //Destroy(quem.gameObject);
            quem.transform.position = checkpoint.position;
        }
    }
	
}
