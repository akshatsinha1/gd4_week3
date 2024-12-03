using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float xRange = 13.5f;

    public GameObject projectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

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


        //spawning projectiles

        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(projectile, transform.position + new Vector3(0, 0, 1), Quaternion.identity);
        }
        
;    }
}
