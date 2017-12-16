using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour {
    AudioSource coincollecter;
    
    public int frut;
    private void Start()
    {

        AudioSource[] audioSources = GetComponents<AudioSource>();
        coincollecter = audioSources[0];
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            GameObject.Find("Score").GetComponent<Score>().addscore(frut);
            GameObject.Find("coincollecter").GetComponent<AudioSource>().Play();



            Destroy(gameObject);
        }
    }
}
