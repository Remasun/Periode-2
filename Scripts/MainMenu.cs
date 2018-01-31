using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject l;

	// Use this for initialization
	void Start () {
        l.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        l.transform.Rotate(0, 0, 45 * Time.deltaTime);
		if (Input.anyKeyDown)
        {
            l.gameObject.SetActive(true);
            SceneManager.LoadScene("Game");
        }
	}
}
