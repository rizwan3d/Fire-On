using UnityEngine;
using System.Collections;

public class astroids : MonoBehaviour {

    [SerializeField]
    float speed = 0;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-200, 200);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0 - speed);

    }
    
    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "fire")
        {
            Destroy(this.gameObject);
            Destroy(c.gameObject);
        }
    }

}
