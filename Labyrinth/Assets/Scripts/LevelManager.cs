using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public GameObject ball;

void OnTriggerEnter(Collider ChangeScene)
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            Destroy(ball);
            SceneManager.LoadScene("Level2");
            
        }
    }
}
