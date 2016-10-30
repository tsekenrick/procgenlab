using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restartStage : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            SceneManager.LoadScene(0);
            Instantiate(player, transform.position, Quaternion.identity);
            player.GetComponent<PathMaker>().cubeCountResetter = 0;
        }
    }
}
