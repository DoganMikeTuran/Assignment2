using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonWalk : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    private float mouseInput;

    
    public float speed;
    public float turnSpeed;
    public float mouseTurnSpeed;

    public float playerSetX;
    public float playerSetY;
    public float playerSetZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        mouseInput = Input.GetAxis("Mouse X");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * mouseTurnSpeed * mouseInput);

        if (Input.GetKeyDown(KeyCode.Space)) {
            transform.position += new Vector3(playerSetX, playerSetY, playerSetZ);
        }
       
        
    }
    
}
