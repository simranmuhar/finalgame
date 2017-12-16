using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    AudioSource gunload;
    public string type;
    public void Start()
    {
        AudioSource[] audiosources = GetComponents<AudioSource>();
        gunload = audiosources[0];
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (type=="bomb")
        {
            string mbomb = GameObject.Find("player").GetComponent<gunHero>().bomb;
         


            GameObject.Find("player").GetComponent<gunHero>().bomb = "yes";
            GameObject.Find("gunload").GetComponent<AudioSource>().Play();

            Destroy(gameObject);
        }
        if (type == "gun")
        {
            string mgun = GameObject.Find("player").GetComponent<gunHero>().gun;


            GameObject.Find("player").GetComponent<gunHero>().gun = "yes";
            GameObject.Find("gunload").GetComponent<AudioSource>().Play();

            Destroy(gameObject);
        }



    }
        
    }
