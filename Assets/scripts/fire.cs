using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {

    [SerializeField]
    float speed = 0;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
	}
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
