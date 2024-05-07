using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_Player : MonoBehaviour
{
    // Andar
    public float velocidadeMovimento = 5f;

    // Pulo
    public float jumpForce = 5f;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // O presonagem anda
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        Vector3 movimento = new Vector3(movimentoHorizontal, 0f, 0f) * velocidadeMovimento * Time.deltaTime;
        transform.Translate(movimento);

        // O presonagem pula
        isGrounded = Physics2D.OverlapCircle(transform.position, groundCheckRadius, groundLayer);
        if (Input.GetButtonDown("Jump"))
        {
           Jump();
        }
    }
    // Parte da função pular
    void Jump()
    {
       rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
