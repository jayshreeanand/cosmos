using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
 public Vector2 leftForce = new Vector2(-100, 10);
 public Vector2 rightForce = new Vector2(100, 10);
  public Vector2 runVelocity = new Vector2(0,10);
  public Vector2 jumpForce = new Vector2(0,11);
   public float horizontalSpeed = 3f;
private Vector2 fp; // first finger position
private Vector2 lp; // last finger position


  void Start () {
  }

  void Update() {

     if (Input.touchCount > 0)
         {
             var touch = Input.GetTouch(0);
             if (touch.position.x < Screen.width/2)
             {
               transform.position += Vector3.left * horizontalSpeed * Time.deltaTime;
             }
             else if (touch.position.x > Screen.width/2)
             {

             transform.position += Vector3.right * horizontalSpeed * Time.deltaTime;
             }
         }
  }

  void FixedUpdate() {
        if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.position += Vector3.left * horizontalSpeed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.position += Vector3.right * horizontalSpeed * Time.deltaTime;
         }

    /*

    if (Input.GetKeyDown("up")) {
      //GetComponent<Rigidbody2D>().velocity = runVelocity;
      Debug.Log("up arrow pressed");

      GetComponent<Rigidbody2D>().AddRelativeForce(jumpForce, ForceMode2D.Force);

      //GetComponent<Rigidbody2D>().velocity = Vector2.zero;

    }


    if (Input.GetKeyDown("left")) {
      Debug.Log("left arrow pressed");
      //GetComponent<Rigidbody2D>().velocity = runVelocity;

      GetComponent<Rigidbody2D>().AddRelativeForce(leftForce, ForceMode2D.Force);

      //GetComponent<Rigidbody2D>().velocity = Vector2.zero;

    }

    if (Input.GetKeyDown("right")) {
      Debug.Log("right arrow pressed");
      GetComponent<Rigidbody2D>().AddRelativeForce(rightForce, ForceMode2D.Force);


    }
    */
  }
}
