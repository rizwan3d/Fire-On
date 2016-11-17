using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    [SerializeField]
    GameObject Asstroid1;
    [SerializeField]
    GameObject Asstroid2;
	// Use this for initialization
	void Start () {
        InvokeRepeating("GenreatAstroids", 1f, 1f);
	}
	void Update()
    {
        if(Player.gameover)
            CancelInvoke("GenreatAstroids");
    }
	// Update is called once per frame
	void GenreatAstroids() {
        int r = Random.Range(0, 20);
        if (r < 10)
            Instantiate(Asstroid1, new Vector3(Random.Range(-5.28f, 5.9f), 7.157177f, 0),Quaternion.identity);
        else
            Instantiate(Asstroid2, new Vector3(Random.Range(-5.28f, 5.9f), 7.157177f, 0),Quaternion.identity);

    }
    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "astroid")
            Destroy(c.gameObject);
    }
}
