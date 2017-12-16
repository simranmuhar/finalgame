using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coins : MonoBehaviour {
    
    AudioSource coincollecter;
    public int scre;
    private void Start()
    {
        
     //   AudioSource[] audioSources = GetComponents<AudioSource>();
      //  coincollecter = audioSources[1];
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.layer==LayerMask.NameToLayer("player"))
        {
            GameObject.Find("Score").GetComponent<Score>().addscore(scre);
            GameObject.Find("coincollecter").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
       
        }
    }
}
