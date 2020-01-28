using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestruction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
    	if(other.gameObject.tag == "Player")
    	{
    		Debug.Log("Game Over");
    	}
    	Destroy(other.gameObject);
    	Destroy(this.gameObject);
    }
}
