using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    private float horizontal;
    private float vertical;
    public int speedRotation = 50;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    
    // Update is called once per frame
    void Update()
    { 
        horizontal = Input.GetAxis ("Horizontal");
        vertical = Input.GetAxis ("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * speedRotation * horizontal);
        
        if (Input.GetKey(KeyCode.R)){
            transform.rotation = Quaternion.identity;
            transform.Translate(Vector3.up * 0.01f);
        }
        
    }
}
