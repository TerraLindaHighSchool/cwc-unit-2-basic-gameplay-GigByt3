using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyForwards : MonoBehaviour
{
	public float speed = 40;
	private float topBound = 60;

    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(this.transform.position.z > topBound || this.transform.position.z < -topBound)
        {
        	Destroy(this.gameObject);
        }
    }
}
