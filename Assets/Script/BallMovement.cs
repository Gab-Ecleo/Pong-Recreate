using System;
using UnityEngine;


public class BallMovement : MonoBehaviour
{

    #region Variables

    [SerializeField]private float speed;

    private Rigidbody2D rBody;

    #endregion

    #region UnityMethods

    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();

        LaunchBall();
    }

    #endregion

    #region Methods

    void LaunchBall()
    {
        float x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        float y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        rBody.velocity = new Vector2(x, y) * speed;
    }

    #endregion

}
