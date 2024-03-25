using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject checkPoint;

    Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Checkpoint"){
            spawnPoint = collider.transform.position;
        }
    }
}
