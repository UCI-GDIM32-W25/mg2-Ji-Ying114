using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{   
    [SerializeField] private float moveSpeed = 1f;
    //[SerializeField] private Collider2D coinCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (transform.position.x < -8f)
        {
            Destroy(gameObject);
        }
    }
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //   if (other.gameObject.tag == "player")
    //    {
    //        Debug.Log("Coin Triggered");
    //        Destroy(gameObject);
    //    }
    //}
}
