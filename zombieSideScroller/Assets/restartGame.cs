using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartGame : MonoBehaviour {

    public float restartTime;
    bool resetNow = false;
    float resetTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(resetNow && resetTime <= Time.time) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKey("escape"))
            Application.Quit();
	}

    public void restartTheGame() {
        resetNow = true;
        resetTime = resetTime + Time.time;
    }

    public void quitGame() {
        Application.Quit();
    }
}
