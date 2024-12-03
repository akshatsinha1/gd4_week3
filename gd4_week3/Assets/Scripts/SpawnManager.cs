using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject animal;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(animal, transform.position + new Vector3(0, 0, 1), Quaternion.Euler(0, Random.Range(0, 360), 0));
        }


        if (Input.GetKeyDown(KeyCode.Space)) //returns true for one frame when you push down the button 
            if (Input.GetKey(KeyCode.Space)) //returns true while a button is pushed down 
                if (Input.GetKeyUp(KeyCode.Space)) { }//returns true for one frame after the user lets go of a button






    }
}
