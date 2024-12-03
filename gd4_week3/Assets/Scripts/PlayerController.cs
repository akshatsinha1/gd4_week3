using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float xRange = 13.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        //METHOD 1
        //transform.Translate(moveSpeed * horizontalMove * Time.deltaTime * Vector3.right);
        //transform.Translate(moveSpeed * verticalMove * Time.deltaTime * Vector3.forward);

        //METHOD 2
        Vector3 moveDir = new Vector3(horizontalMove,0,verticalMove).normalized;
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);


        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,0,transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, 0, transform.position.z);
        }
    }
}


//Add forwards/Backwards Movement
//Have bounds on the Z axis as well
