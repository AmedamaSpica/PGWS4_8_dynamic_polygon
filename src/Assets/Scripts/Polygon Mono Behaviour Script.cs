using System.Net.Mail;
using UnityEngine;
using UnityEngine.UIElements;

public class PolygonMonoBehaviourScript : MonoBehaviour
{
    Mesh mesh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        mesh = GetComponent<MeshFilter>().mesh;

        Vector3[] Vertices =
        {
            new Vector3(1.0f,0.0f,0.0f),
            new Vector3(0.0f,1.0f,0.0f),
            new Vector3(0.0f,0.0f,1.0f),
        };
        
        Color[] Colors = { Color.red, Color.green, Color.blue };
        int[] triangles = { 0, 1, 2 };

        mesh.Clear();
        mesh.vertices = Vertices;
        mesh.colors = Colors;
        mesh.triangles = triangles;

        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
