using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float rotationSpeed = 0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Vertical");
        float rotationZ = Input.GetAxis("Horizontal");

        Vector3 rotation = new Vector3(rotationX, 0F, -rotationZ);

        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);

    }
}
