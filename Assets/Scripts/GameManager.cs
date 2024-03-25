using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject spawnPrefab;
    // Start is called before the first frame update
    void Start()
    {

        GameObject ball = Instantiate(spawnPrefab);

    }

    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
    }

    public void WinGame(){
        Debug.Log("LEVEL 1");
        CompleteLevel();
    }
}
