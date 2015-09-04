using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {

  public Vector2 velocity = new Vector2(-2,0);
  public float range = 2;

	// Update is called once per frame
	void Update () {
	  GetComponent<Rigidbody2D>().velocity = velocity;
    transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}
}
