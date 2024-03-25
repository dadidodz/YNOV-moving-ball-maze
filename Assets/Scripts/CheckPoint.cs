using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static Vector3 respawnPoint;
    
    private void OnTriggerEnter(Collider other){
        Destroy(other.gameObject);
    }
}
