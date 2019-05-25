using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomize : MonoBehaviour {
	public GameObject[] workouts;
	int currentIndex = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NewWorkout(){
		int newIndex = Random.Range (0, workouts.Length);
		workouts [currentIndex].SetActive (false);
		currentIndex = newIndex;
		workouts [currentIndex].SetActive (true);
	}

}
