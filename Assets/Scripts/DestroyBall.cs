using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyBall : MonoBehaviour
{

    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            Debug.Log("Working");
            Destroy(other.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
