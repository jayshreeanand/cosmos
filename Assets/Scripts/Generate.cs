using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

  public GameObject stargroup;
  public GameObject raygroup;
  public GameObject asteroid_small;
  public GameObject asteroid_large;

	// Use this for initialization
	void Start () {

    
	  InvokeRepeating("CreateStar", 0.1f, 0.5f);
    InvokeRepeating("CreateRay", 0.8f, 0.5f);
    InvokeRepeating("CreateAsteroidSmall", 0.7f, 0.7f);
    InvokeRepeating("CreateAsteroidLarge", 2f, 2f);


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

  void CreateAsteroidSmall(){
    Instantiate(asteroid_small);
  }

  void CreateAsteroidLarge(){
    Instantiate(asteroid_large);
  }
}
