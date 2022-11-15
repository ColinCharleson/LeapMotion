using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
	public GameObject punchParticle;
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Bag")
		{
			GameObject punch = Instantiate(punchParticle, this.transform.position, Quaternion.identity);
			Debug.Log("hit");
			StartCoroutine(DestroyParticle(punch));
		}
	}

	IEnumerator DestroyParticle(GameObject punch)
	{
		yield return new WaitForSeconds(1);
		Destroy(punch);
	}

}
