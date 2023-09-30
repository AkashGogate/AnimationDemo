using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class chopchop : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("sit", false);
            animator.SetTrigger("choppchopp");
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("sit", true);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("sit", false);
            animator.SetTrigger("Jump");
            rb.AddForce(Vector2.up*6f , ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("sit", false);
            animator.SetBool("running", true);
            transform.localScale = new Vector3(-1, 1, 1);
            transform.transform.Translate(Vector3.right * 5f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("sit", false);
            animator.SetBool("running", true);
            transform.localScale = new Vector3(1, 1, 1);
            transform.transform.Translate(Vector3.left * 5f * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("running", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("running", false);
        }
        if(animator.GetBool("sit"))
        {

        }
        else
        {
            
        }
    }

}
