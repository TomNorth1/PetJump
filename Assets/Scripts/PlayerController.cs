using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isGrounded;
    Rigidbody rigidbody;
    Animator animController;
    public float distanceTraveled;
    Vector3 startPos;
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private Text scoreText;
    // Start is called before the first frame update



    void Start()
    {
        startPos = transform.position;
        animController = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        distanceTraveled = Vector3.Distance(transform.position, startPos);
        scoreText.text = ((int)distanceTraveled).ToString();
        Vector3 raycastPos = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
        if (Physics.Raycast(raycastPos, Vector3.down, 0.11f))
        {
            isGrounded = true;
        }
        else 
        {
            isGrounded = false;
        }
        
        if (Input.GetButtonDown("Jump") && isGrounded || Input.touchCount > 0 && isGrounded) 
        {
            animController.SetTrigger("OnJump");
            rigidbody.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }       
    }

}
