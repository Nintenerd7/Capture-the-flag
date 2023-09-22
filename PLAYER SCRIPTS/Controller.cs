using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour
{
    //moving variables
    public float speed = 5f;
    private float horizontalInput;
    private float verticalInput;
    //

    //rotation
    public float rotationspeed;
    //

    //falldetector
    public GameObject FallDetector;

    //jumping variables
    public float jumpForce = 5f;
    public bool isOnGround = true;
    //
    Rigidbody Move;
    // Start is called before the first frame update
    void Start()
    {
        Move = GetComponent<Rigidbody>();//activates rigidbody state. 
     
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");//player can turn left and right 
        verticalInput = Input.GetAxisRaw("Vertical");//player can move up and down. 

        //movement 
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);//allows player to move
        movementDirection.Normalize();
        transform.Translate(movementDirection * Time.deltaTime * speed, Space.World);
        //

        //character rotation
        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);//allows rotation 
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationspeed * Time.deltaTime);
        }
        //

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            Move.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);//jump logic 
            isOnGround = false;//can jump 
        }
        else
        {
            isOnGround = true;//keeps player on the ground. 
        }
        //
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FallDetector"))//if player falls into the abyss. 
        {
            SceneManager.LoadScene(3);//loads game over screen
        }
    }

}

