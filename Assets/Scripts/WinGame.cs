using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            gameManager.WinGame();
        }
        
        // Debug.Log("Game win");
        // Destroy(other.gameObject);
        // SceneManager.LoadScene(0);
    }
}
