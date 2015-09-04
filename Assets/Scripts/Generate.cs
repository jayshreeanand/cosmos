using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

  public GameObject star;

	// Use this for initialization
	void Start () {
	 InvokeRepeating("CreateStar", 1f, 1.5f);
	}

	// Update is called once per frame
	void Update () {

	}

  void CreateStar(){
    Instantiate(star);
  }
}
