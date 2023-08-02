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
        posInicial = new Vector3(0f, 0f, 0f);
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(speed,rig.velocity.y);
        if (Input.GetKeyDown(KeyCode.A) && transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.D)&& transform.localScale.x < 0){
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }
}
