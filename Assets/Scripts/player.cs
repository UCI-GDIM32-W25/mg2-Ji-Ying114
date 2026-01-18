using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private controller gameController;

    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        //press space to jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        //rb.AddForce(Vector2.down * gforce * Time.deltaTime, ForceMode2D.Force);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {   
            Debug.Log("Coin Collected");
            gameController.IncreaseScore();
            Destroy(collision.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
}
