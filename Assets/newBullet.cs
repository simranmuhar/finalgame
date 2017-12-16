using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newBullet : MonoBehaviour
{

    public float speed;
    Rigidbody2D rigidbody2d;
    public float delay = 0.05f;
    public GameObject explosion;


    void Awake()
    {
        Vector2 dir = GameObject.Find("player").GetComponent<player1>().GetFaceDirection();
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = dir * speed;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {
           
          
         //   collision.gameObject.GetComponent<Animator>().SetTrigger("isExploding");

            Destroy(col.gameObject); //,this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay
            GameObject ex = Instantiate(explosion, col.transform.position, col.transform.rotation);
            Destroy(ex, 3);

        }

    }



    void Update()
    {

    }
}