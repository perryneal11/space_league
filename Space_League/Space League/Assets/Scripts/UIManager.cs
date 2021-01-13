using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : MonoBehaviour{

GameObject[] pauseObjects;
public static bool isMenuOpen = false;




	// Use this for initialization
	void Start () {
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
	}


	void Update () {


		if(Input.GetKeyDown(KeyCode.Tab) && isMenuOpen == false){
				showPaused();
				isMenuOpen = true;
			} else if(Input.GetKeyDown(KeyCode.Tab) && isMenuOpen == true){
				Debug.Log("hit");
				hidePaused();
				isMenuOpen = false;
			}
		}


	//shows objects with ShowOnPause tag
	public void showPaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}

}
