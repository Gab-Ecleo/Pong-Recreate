using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

    #region variables

    public int dragSpeed = 5;
    
    private Vector2 diff = Vector2.zero;
    private Rigidbody2D rBody;
    private Vector2 pos;

    #endregion

    #region Unity Methods
    
    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        diff = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    {
        pos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - diff;
        
        rBody.velocity = (pos - (Vector2)transform.position) * dragSpeed;
    }

    private void OnMouseUp()
    {
        rBody.velocity = Vector2.zero;
    }

    #endregion

    #region Methods



    #endregion

}
