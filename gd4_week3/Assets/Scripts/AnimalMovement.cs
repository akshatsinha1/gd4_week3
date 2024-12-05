using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float moveSpeed;
    public float xRange, zRange;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.position.x > xRange || transform.position.x < -xRange || transform.position.z > zRange || transform.position.z < -zRange)
        {
            //either of the four contitions need to be true for the code tobe executed
            Destroy(gameObject);
        }


        if (transform.position.x > xRange && transform.position.x < -xRange)
        {
            //both the conditions need to be true for this code to execute
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Projectile")
        {
            //Destroy the Projectile
            Destroy(other.gameObject);

            //Update the score
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score++;
            //GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score + 1;

            //GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score += 1;

            Debug.Log(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score);


            //Destroy ourselves
            Destroy(gameObject);

           


        }
    }

  
}
