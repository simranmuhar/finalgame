using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{

    public GameObject target;
    public float delay = 0.05f;
    string mbomb;
    string mgun;
    public GameObject explosion;
    public GameObject prefabplayer;



    public float fixeddistance = 0.5f;
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 distancefromplayer = target.transform.position - transform.position;
        float magOfDistancefromplayer = distancefromplayer.magnitude;
        Vector3 distancefromplayerN = distancefromplayer.normalized;
        if (magOfDistancefromplayer <= fixeddistance)
        {
            //gameObject.transform.Translate(diatancefromplayer);
            transform.Translate(distancefromplayerN.x * 0.09f, 0, 0);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        mbomb = GameObject.Find("player").GetComponent<gunHero>().bomb;
        mgun = GameObject.Find("player").GetComponent<gunHero>().gun;
        if (col.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            if (mbomb == "yes")
            {
                Vector2 pos = col.transform.position;
                pos.x = pos.x - .001f;
                pos.y = pos.y + .5f;

                col.transform.Translate(pos);

                GameObject.Find("player").GetComponent<gunHero>().bomb = "no";
                GameObject ex = Instantiate(explosion, col.transform.position, col.transform.rotation);
                Destroy(ex, .5f);
                SceneManager.LoadScene("gameoverscene");

            }
            if (mgun=="yes")
            {
                Vector2 pos = col.transform.position;
                pos.x = pos.x - .3f;
                pos.y = pos.y + .3f;

                col.transform.Translate(pos);

                GameObject.Find("player").GetComponent<gunHero>().gun = "no";
                GameObject ex = Instantiate(explosion, col.transform.position, col.transform.rotation);
                Destroy(ex, .5f);
                SceneManager.LoadScene("gameoverscene");

            }
            if (mgun == "no"&& mbomb == "no")
            {
                
                    Destroy(col.gameObject);

                    GameObject ex = Instantiate(explosion, col.transform.position, col.transform.rotation);
                    Destroy(ex, 3);
                    SceneManager.LoadScene("gameoverscene");


                
            }
        }
            
       
             

    }

}