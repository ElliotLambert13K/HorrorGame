using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementScript : MonoBehaviour
{
    private int speedRun = 10;
    private int speedJump = 300;
    public bool facingRight = false;
    public float moveOnX;
    public bool grounded;
    public bool interactionWorld;
    public bool interactionRoom;
    public bool interactionClass;


    // Update is called once per frame
    void Update()
    {
        playerMovement();
        Interact();
    }

    void playerMovement()
    {

        moveOnX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            Jump();
        }
        if (moveOnX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveOnX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveOnX * speedRun, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            grounded = true;
        }
        if (col.gameObject.tag == "ChangeSceneWorld")
        {
            interactionRoom = true;
        }
        if (col.gameObject.tag == "ChangeSceneRoom")
        {
            interactionWorld = true;
        }
        if (col.gameObject.tag == "ChangeSceneClass")
        {
            interactionClass = true;
        }
    }
    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * speedJump);
        grounded = false;
        Debug.Log("bruh");
    }
    void Interact()
    {
        if (Input.GetButtonDown("Fire2") && interactionWorld == true)
        {
            SceneManager.LoadScene("LevelRoomBase");
            Debug.Log("Crime");
            interactionWorld = false;
        }
        if (Input.GetButtonDown("Fire2") && interactionRoom == true)
        {
            SceneManager.LoadScene("MainSceneUncorr");
            Debug.Log("War");
            interactionRoom = false;
        }
        if (Input.GetButtonDown("Fire2") && interactionClass == true)
        {
            SceneManager.LoadScene("ClassroomUncorr");
            Debug.Log("Endme");
            interactionClass = false;
        }
    }
}
