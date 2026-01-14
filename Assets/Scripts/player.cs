using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private controller gameController;
    //[SerializeField] private float gforce = 9.81f;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        //press space to jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
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
}
