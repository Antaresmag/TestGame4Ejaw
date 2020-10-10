using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using Random = System.Random;

public class DataOnMash : MonoBehaviour
{
    public static bool createObj = false;
    public int countClick = 0;
    public Text clickText;
    public GameObject cube, sphere, capsule;
    public Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        //cube.GetComponent<GameObject>();
        //clickText.text = clickText.ToString();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            //CreateMesh();
            Debug.Log("Click");
            RaycastHit hit;




            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Zone" && createObj == false)
                {
                    Random rnd = new Random();
                    int num = rnd.Next(1, 4);
                    Debug.Log(num);

                    switch (num)
                    {
                        case 1:
                            Instantiate(cube, hit.point, Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(sphere, hit.point, Quaternion.identity);
                            break;
                        case 3:
                            Instantiate(capsule, hit.point, Quaternion.identity);
                            break;

                    }
                    //Instantiate(cube, hit.point, Quaternion.identity);
                    Debug.Log("Creat obj");
                    createObj = true;



                }
                else if (hit.transform.name == "Cube(Clone)" || hit.transform.name == "Capsule(Clone)" || hit.transform.name == "Sphere(Clone)")
                {
                    Debug.Log("Hit in Cube");
                    countClick++;
                    clickText.text = Mathf.Round(countClick).ToString();
                    Debug.Log(countClick);

                }
                else
                {
                    Debug.Log("miss");
                  
                }
            }
        }

    }



    //void CreateMesh()
    //{
    //    Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    cube.CreatePrimitive(CurrentPrimitive).transform.Translate(mRay.origin + (mRay.direction * primDistance));
    //    //Instantiate(cube, Input.mousePosition));
    //}
}
