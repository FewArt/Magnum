﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoom : MonoBehaviour {

	public RectTransform rt;

	float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;

	Vector2 firstTouchPrevPos, secondTouchPrevPos;

	[SerializeField]
	float zoomModifierSpeed = 0.1f;

	[SerializeField]
	Text text;

	// Use this for initialization
	void Start () {
		rt = GetComponent<RectTransform> ();
        rt.transform.localScale = new Vector3(rt.localScale.x+0.1f,rt.localScale.y+0.1f,2);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount == 2) {
			Touch firstTouch = Input.GetTouch (0);
			Touch secondTouch = Input.GetTouch (1);

			firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
			secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;

			touchesPrevPosDifference = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
			touchesCurPosDifference = (firstTouch.position - secondTouch.position).magnitude;

			zoomModifier = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModifierSpeed;
    
			if (touchesPrevPosDifference > touchesCurPosDifference)
				rt.transform.localScale = new Vector3(rt.localScale.x+zoomModifier,rt.localScale.y-zoomModifier,1);
			if (touchesPrevPosDifference < touchesCurPosDifference)
				rt.transform.localScale = new Vector3(rt.localScale.x-zoomModifier,rt.localScale.y+zoomModifier,1);
			
		}
        rt.transform.localScale = new Vector3 (Mathf.Clamp(rt.transform.localScale.x,1,2), Mathf.Clamp(rt.transform.localScale.y,1,2), 1);
        //rt.transform.localScale = Mathf.Clamp(rt.transform.localScale.y, 1, 2);
		//mainCamera.orthographicSize = Mathf.Clamp (mainCamera.orthographicSize, 2f, 10f);
	}
}
