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

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Catcher"))
        {
            GameManager.pScore += 1;
            Debug.Log("Player Scored");
        }
            
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameManager.gameOver = true;
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
