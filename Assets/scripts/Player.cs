using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {

    public static bool gameover = false;


    bool left = false, right = false , Dofire = false;

    Rigidbody2D r;
    
    [SerializeField]
    float speed = 0;
    [SerializeField]
    Sprite leftSprint, rightSprite, idelSprint;
    [SerializeField]
    GameObject fire;
  

    // Use this for initialization
    void Start () {
        r = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left = true;
            right = false;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            right = true;
            left = false;           
        }
        else
        {
            left = false;
            right = false;
        }

        if (Input.GetKey(KeyCode.Space))
            Dofire = true;
    }

    private void fireFun()
    {
        Instantiate(fire, transform.position, Quaternion.identity);
    }

    void FixedUpdate()
    {
        if (left)
            Left();
        else if (right)
            Right();
        else
            Idel();
        if (Dofire)
        {
            Dofire = false;
            fireFun();            
        }


    }
    void Idel()
    {
        GetComponent<SpriteRenderer>().sprite = idelSprint;
        r.velocity = new Vector2(0, 0);
    }
    void Left()
    {
        GetComponent<SpriteRenderer>().sprite = leftSprint;
        r.velocity = new Vector2(0 - speed, 0);
    }
    void Right()
    {
        GetComponent<SpriteRenderer>().sprite = rightSprite;
        r.velocity = new Vector2(speed, 0);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "astroid")
        {
            Destroy(this.gameObject);
            gameover = true;
        }
    }

}
