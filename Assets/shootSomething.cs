using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootSomething : MonoBehaviour {
    public GameObject projecttile;
    public Vector2 Velocity;
    bool Canshoot = true;
    public Vector2 offset = new Vector2(0.4f, 0.1f);
    public float cooldown = 1f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown (KeyCode.T) && Canshoot)
        {
            GameObject go =(GameObject)Instantiate(projecttile, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
            go.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity.x * transform.localScale.x, Velocity.y);
        }
		
	}
    IEnumerator canshoot()
    {
        Canshoot = false;
        yield return new WaitForSeconds(cooldown);
        Canshoot = true;
    }
}
