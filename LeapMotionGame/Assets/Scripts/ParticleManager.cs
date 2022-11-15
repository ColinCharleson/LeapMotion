using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
	public GameObject punchParticle;
	private void OnTriggerEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Bag")
		{
			Instantiate(punchParticle, this.transform.position, Quaternion.identity);
			Debug.Log("hit");
		}
	}
}
