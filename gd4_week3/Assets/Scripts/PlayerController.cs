using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float xRange = 13.5f;

    public GameObject projectile;

    public int score;

    public TMP_Text scoreText;

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
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);

        transform.rotation = Quaternion.LookRotation(moveDir);

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
            Destroy(Instantiate(projectile, transform.position + transform.forward, transform.rotation),5);
            
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
        }


        //Update the score UI
        scoreText.text = "Score: " + score;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Animal")
        {
            SceneManager.LoadScene(0);
        }
    }

}
