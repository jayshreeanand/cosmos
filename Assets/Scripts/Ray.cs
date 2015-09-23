using UnityEngine;
using System.Collections;

public class Ray : MonoBehaviour {

	public Vector2 velocity = new Vector2(0,-50);
  public float range = 6;

  // Update is called once per frame
  void Start () {
    GetComponent<Rigidbody2D>().velocity = velocity;
    transform.position = new Vector3(transform.position.x + range * Random.value, transform.position.y , transform.position.z);

  }
}
