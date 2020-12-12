using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour { 

    public PlayerController thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;
        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
        lastPlayerPosition = thePlayer.transform.position;
    }

    public IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 originalPosition = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            //float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-2f, 2f) * magnitude;

            transform.localPosition = new Vector3(originalPosition.x, y, originalPosition.z);

            elapsed += Time.deltaTime;

            yield return null;
        }
        transform.localPosition = new Vector3(originalPosition.x, 0, originalPosition.z);
    }
}
