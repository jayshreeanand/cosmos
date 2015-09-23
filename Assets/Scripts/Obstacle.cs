using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

  public float range = 4;
  public Vector2 velocity = new Vector2(0, -5);

	// Use this for initialization
	void Start () {
	
    GetComponent<Rigidbody2D>().velocity = velocity;
    transform.position = new Vector3(transform.position.x * Random.value + range, transform.position.y * Random.value + range , transform.position.z);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnTriggerEnter2D(Collider2D other)
  {

    if(other.gameObject.tag == "player") 
    print("asteroid hit");
      gameObject.SetActive(false);
  }
  
}
