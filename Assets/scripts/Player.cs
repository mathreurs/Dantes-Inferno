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
    private float speed = 5;
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        posInicial = new Vector3(-0.67f, -1.29f, 0f);
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(speed,rig.velocity.y);
        rig.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rig.velocity.y);
        if (Input.GetAxis("Horizontal")!= 0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.D)&& transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Line"))
        {
            //retorno do personagem para a posição inicial
            transform.position = posInicial;
        }  

    }
}
