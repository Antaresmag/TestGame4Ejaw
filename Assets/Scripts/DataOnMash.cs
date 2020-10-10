using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class DataOnMash : MonoBehaviour
{
    public static bool createObj = false;
    public int countClick = 0;
    public Text clickText;
    public GameObject cube;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        //cube.GetComponent<GameObject>();
        clickText.text = clickText.ToString();
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

            if(Physics.Raycast(ray,out hit))
            {
                if(hit.transform.name == "Zone" && createObj == false)
                {
                    
                    Instantiate(cube, hit.point, Quaternion.identity);
                    Debug.Log("Creat obj");
                    createObj = true;

                }
                else if(hit.transform.name == "Cube" || hit.transform.name == "Cube(Clone)")
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
