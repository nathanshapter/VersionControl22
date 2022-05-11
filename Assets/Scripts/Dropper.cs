using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private bool onlyOnce = false;
    [SerializeField] float fallingTimer = 3f;
    Renderer MeshRenderer;
    Rigidbody rb;
 void Start()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
        MeshRenderer.enabled = false;

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    private void Update()
    {
      
        if(Time.time > fallingTimer && onlyOnce == false)
        {
            print("f");
            onlyOnce = true;
            rb.useGravity = true;
            MeshRenderer.enabled = true;
        }
    }
}
