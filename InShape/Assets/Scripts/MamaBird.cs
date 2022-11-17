using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MamaBird : MonoBehaviour
{

    public float speed = 0.4f;
    public float rotation_damping = 4f;
    public Camera ARCamera;

    // Start is called before the first frame update
    void Start()
    {
        ARCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        // MamaBird's rotation
        var rotation = Quaternion.LookRotation(ARCamera.transform.position - transform.position);
        this.transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotation_damping);

        // MamaBird fly upwards
        this.transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
        
    }
}
