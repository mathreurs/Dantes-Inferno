using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    //variavel para rig
    private Rigidbody2D rig;
    //vetor de posição inicial
    private Vector3 posInicial;
    //variavel da velocidade
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        posInicial = new Vector3(0, 0, 0);
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
