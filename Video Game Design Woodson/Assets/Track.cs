using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject p;
	private Vector3 offset;
    void Start()
    {
        offset = transform.position - p.transform.position;
		Debug.Log(offset, p);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = p.transform.position + offset;
    }
}
