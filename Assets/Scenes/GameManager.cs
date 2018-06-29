using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour {
   

	// Use this for initialization
	void Start () {
      //  score = 0;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }

       


	}


}
