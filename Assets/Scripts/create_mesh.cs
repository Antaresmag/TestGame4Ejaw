using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_mesh : MonoBehaviour
{
    // Start is called before the first frame update
    public float widht = 5f;
    public float height = 5f;


    void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        mf.mesh = mesh;

        // Vershyny
        Vector3[] vert = new Vector3[4]
        {
            new Vector3(0,0,0), new Vector3(widht,0,0), new Vector3 (0,height,0), new Vector3(widht, height, 0)
        };


        // Tribl
        int[] tri = new int[6];
        tri[0] = 0;
        tri[1] = 2;
        tri[2] = 1;

        tri[3] = 2;
        tri[4] = 3;
        tri[5] = 1;


        // UV
        Vector2[] uv = new Vector2[4]
        {
            new Vector2(0,0), new Vector2 (1,0), new Vector2(0,1) ,new Vector2 (1,1)

        };

        //naznachenie

        mesh.vertices = vert;
        mesh.triangles = tri;
        mesh.uv = uv;


    }


}
