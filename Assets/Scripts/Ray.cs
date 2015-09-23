using UnityEngine;
using System.Collections;

public class Ray : MonoBehaviour {

	public Vector2 velocity = new Vector2(0,-50);

  // Update is called once per frame
  void Start () {
    GetComponent<Rigidbody2D>().velocity = velocity;
  }
}
