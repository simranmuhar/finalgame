using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunHero : MonoBehaviour {
    public GameObject bulletprefab;
    public GameObject bombprefab;
    public float delaytime = 0.25f;
    public string bomb;
    public string gun;
    public GameObject explosion;

    float cooldown = 0;

    // Use this for initialization
    void Start () {
        AudioSource[] audiosources = GetComponents<AudioSource>();

		
	}
	
	// Update is called once per frame
	void Update () {
        cooldown -= Time.deltaTime;
       
            if (Input.GetButton("Fire") & cooldown <= 0&&gun=="yes")
            {
                cooldown = delaytime;
                Instantiate(bulletprefab, transform.position, transform.rotation);
                GameObject.Find("player").GetComponent<Animator>().SetTrigger("isShooting");


        }

        else 
            if (Input.GetButton("Fire1") & cooldown <= 0&& bomb == "yes")
            {
                Vector2 pos;
                pos.x = transform.position.x + 0.6f;
                pos.y = transform.position.y + 1.3f;

                cooldown = delaytime;
                Instantiate(bombprefab, pos, Quaternion.Euler(0, 0, -90));


                GameObject.Find("player").GetComponent<Animator>().SetTrigger("isShooting");

        }


    }
}
