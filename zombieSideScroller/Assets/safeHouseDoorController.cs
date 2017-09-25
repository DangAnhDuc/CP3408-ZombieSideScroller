using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class safeHouseDoorController : MonoBehaviour {

    AudioSource safeDoorAudio;

    //HUD
    public Text endGameText;
    public restartGame theGameController;

    // Use this for initialization
    void Start () {
        safeDoorAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            Animator safeDoorAnim = GetComponentInChildren<Animator>();
            safeDoorAnim.SetTrigger("safeHouseTrigger");
            safeDoorAudio.Play();
            endGameText.text = "Safe House";
            Animator endGameAnim = endGameText.GetComponent<Animator>();
            endGameAnim.SetTrigger("endGame");
            theGameController.restartTheGame();
        }
    }
}
