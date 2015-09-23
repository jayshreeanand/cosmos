using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

  public GameObject stargroup;
  public GameObject raygroup;

	// Use this for initialization
	void Start () {

    
	  InvokeRepeating("CreateStar", 0.1f, 0.5f);
    InvokeRepeating("CreateRay", 0.8f, 0.5f);


	}

	// Update is called once per frame
	void Update () {

	}

  void CreateStar(){
    Instantiate(stargroup);
  }

  void CreateRay(){
    Instantiate(raygroup);
  }
}
