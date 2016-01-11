using UnityEngine;
using System.Collections;

public class MorphBlock : MonoBehaviour {

	[SerializeField]
	AnimationCurve moveBlock;

	public float moveSpeed, rotateSpeed;

	public Vector3 pos1, pos2, pos3, pos4;
	bool morphShape = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			morphShape = true;	
		} else {
			morphShape = false;
		}

		if (morphShape) {
			transform.position = Vector3.MoveTowards (transform.position, pos2, Time.deltaTime * moveSpeed * Random.Range(1,3));
			transform.Rotate (new Vector3 (0, Time.deltaTime * rotateSpeed * Random.Range(-1,1), 0));
		} else {
			transform.position = Vector3.MoveTowards (transform.position, pos1, Time.deltaTime * moveSpeed);
			transform.rotation = Quaternion.Euler (Vector3.MoveTowards (transform.rotation.eulerAngles, new Vector3 (0, 0, 0), Time.deltaTime * rotateSpeed * 100));
		}

	}
}
