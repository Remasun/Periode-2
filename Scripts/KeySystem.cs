using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySystem : MonoBehaviour {

    public int keys;
    public GameObject p;
    public Component t;

	// Use this for initialization
	void Start () {
        t.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (keys >= 5)
        {
            GameWin();
        }
	}

    public void GameWin()
    {
        print("win!");
        p.GetComponent<CameraScript>().inMenu = true;
        t.gameObject.SetActive(true);
    }

    public void Key(GameObject u)
    {
        keys += 1;
        Destroy(u);
    }
}
