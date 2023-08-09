using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform.parent.gameObject.GetComponent<Player>();
    }
    //quando o player começar a colidir 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            Debug.Log("COLIDIU");
        }
    }
    //quando o player parar de colidir 
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            Debug.Log("saiu");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
