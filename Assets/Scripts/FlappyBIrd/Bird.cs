using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float jumpForce = 5f;
    private Bird_inputs bird;

    private void Awake()
    {
        bird = new Bird_inputs();
        bird.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bird.Standard.Jump.performed += Move;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void Move(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        Debug.Log("SALTÓ");
    }

}
