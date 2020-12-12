using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public PlayerController thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    void Update()
    {

        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }

}
