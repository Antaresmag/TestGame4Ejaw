using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using Random = System.Random;

public class DataOnMash : MonoBehaviour
{
    public static bool createObj = false; // Эта переменая нужна для создания не больше одного оъекта. Так как мы будем проверять сколько кликов было на нём
    public static int countClick = 0;     // Количество кликов
    public Text clickText;                // Вывод текста с количеством кликов
    public GameObject cube, sphere, capsule; // Объекты которые создаются рандомно
    public Camera cam;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            RaycastHit hit; // луч 
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); // фиксация позиции луча за мышкой
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
}
