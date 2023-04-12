using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrCamera : MonoBehaviour {
    public Transform player;
    private Vector3 novaPosicaoCamera;
    public float padrao = -10;
    public float compensacao;

	// Use this for initialization
	void Start () {
		
	}
    void movimento()
    {
        novaPosicaoCamera = new Vector3(player.transform.position.x, player.transform.position.y + compensacao, padrao);
        transform.position = Vector3.Lerp(transform.position, novaPosicaoCamera, 3 * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
        movimento();
	}
}
