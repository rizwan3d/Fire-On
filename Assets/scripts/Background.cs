using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
    [SerializeField]
    Sprite sprite;
    [SerializeField]
    GameObject[] backgroundsprite;
    [SerializeField]
    float speed = 0;

	// Use this for initialization
	void Start () {
            backgroundsprite = GameObject.FindGameObjectsWithTag("backgroundSprite");
        foreach(GameObject g in backgroundsprite)        
            g.GetComponent<SpriteRenderer>().sprite = sprite;
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= -10.9)
            transform.position = new Vector3(0, -6.380014f, 0);
        transform.position += new Vector3(0, 0 - speed, 0);
	}
}
