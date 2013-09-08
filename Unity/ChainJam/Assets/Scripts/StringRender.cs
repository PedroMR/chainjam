using UnityEngine;
using System.Collections;

public class StringRender : MonoBehaviour {
	SpringJoint joint;
	LineRenderer lineRenderer;


	public Color c1 = Color.white;
	public Color c2 = Color.white;
	public int lengthOfLineRenderer = 2;
	void Start() {
		joint = GetComponent<SpringJoint>();
		LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
		lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
		lineRenderer.SetColors(c1, c2);
		lineRenderer.SetWidth(0.05F, 0.05F);
		lineRenderer.SetVertexCount(lengthOfLineRenderer);
	}
	/**
	void Update() {
		LineRenderer lineRenderer = GetComponent<LineRenderer>();
		int i = 0;
		while (i < lengthOfLineRenderer) {
			Vector3 pos = new Vector3(i * 0.25F, Mathf.Sin(i*0.5f + Time.time), 0);
			lineRenderer.SetPosition(i, pos);
			i++;
		}
	}
	/*/

	// Update is called once per frame
	void Update () {
		if (joint != null)
		{
			var body = joint.connectedBody;
			if (body != null)
			{
				var lineRenderer = GetComponent<LineRenderer>();
				lineRenderer.SetPosition(0, body.transform.position);
				lineRenderer.SetPosition(1, transform.position);
//				for (int i=0; i < lengthOfLineRenderer; i++) {
//				}
				Debug.DrawLine(body.transform.position, transform.position, Color.magenta);
			}
		}
	}
	/**/
}
