using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
	private float horizontalInput;
	public float speed = 10;
	public float xRange = 10;
	public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(this.transform.position.x < -xRange)
        {
        	this.transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        } else if(this.transform.position.x > xRange)
        {
        	this.transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
        	Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
