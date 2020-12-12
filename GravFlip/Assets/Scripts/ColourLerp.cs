using UnityEngine;

public class ColourLerp : MonoBehaviour
{

    MeshRenderer enemyMesh;
    [SerializeField] [Range(0f, 20f)] float lerpTime;

    [SerializeField] Color[] myColours;

    int colourIndex = 0;

    float t = 0f;

    int len;

    void Start()
    {

        enemyMesh = GetComponent <MeshRenderer> ();
        len = myColours.Length;

    }

    void Update()
    {

        enemyMesh.material.color = Color.Lerp (enemyMesh.material.color, myColours[colourIndex], lerpTime*Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerpTime*Time.deltaTime);

        if (t > 0.9f)
        {
            t = 0f;
            colourIndex++;
            colourIndex = (colourIndex >= len) ? 0 : colourIndex;        
        }

    }
}
