using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrAcidBall : MonoBehaviour
{
    public Transform final;
    public Transform inicial;
    Vector2 destino;
    public float velocidade = 5f;

    // Use this for initialization
    void Start()
    {

        destino = final.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, destino, velocidade * Time.fixedDeltaTime);
        if (transform.position == final.position)
        {
            destino = inicial.position;
        }
        if (transform.position == inicial.position)
        {
            destino = final.position;
        }
    }
}
