using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject circle, diamond, hexagon, rectangle, triangle, circleblack, diamondblack, hexagonblack, rectangleblack, triangleblack;

    
    public Button btnn;
    public Button btn;
    

    Vector2 circleInitialPos, diamondInitialPos, hexagonInitialPos, rectangleInitialPos, triangleInitialPos;

    bool circleCorrect, diamondCorrect, hexagonCorrect, rectangleCorrect, triangleCorrect = false;

    void Start()
    {
        circleInitialPos = circle.transform.position;
        diamondInitialPos = diamond.transform.position;
        hexagonInitialPos = hexagon.transform.position;
        rectangleInitialPos = rectangle.transform.position;
        triangleInitialPos = triangle.transform.position;
    }
    public void DragCircle()
    {
        circle.transform.position = Input.mousePosition;
    }
    public void DragDiamond()
    {
        diamond.transform.position = Input.mousePosition;
    }
    public void DragHexagon()
    {
        hexagon.transform.position = Input.mousePosition;
    }
    public void DragRectangle()
    {
        rectangle.transform.position = Input.mousePosition;
    }
    public void DragTriangle()
    {
        triangle.transform.position = Input.mousePosition;
    }


    public void DropCircle()
    {
        float Distance = Vector3.Distance(circle.transform.position, circleblack.transform.position);
        if (Distance < 50)
        {
            circle.transform.position = circleblack.transform.position;
            circleCorrect = true;
        }
        else
        {
            circle.transform.position = circleInitialPos;
        }
    }
    public void DropDiamond()
    {
        float Distance = Vector3.Distance(diamond.transform.position, diamondblack.transform.position);
        if (Distance < 50)
        {
            diamond.transform.position = diamondblack.transform.position;
            diamondCorrect = true;
        }
        else
        {
            diamond.transform.position = diamondInitialPos;
        }

    }
    public void DropHexagon()
    {
        float Distance = Vector3.Distance(hexagon.transform.position, hexagonblack.transform.position);
        if (Distance < 50)
        {
            hexagon.transform.position = hexagonblack.transform.position;
            hexagonCorrect = true;
        }
        else
        {
            hexagon.transform.position = hexagonInitialPos;
        }
    }
    public void DropRectangle()
    {
        float Distance = Vector3.Distance(rectangle.transform.position, rectangleblack.transform.position);
        if (Distance < 50)
        {
            rectangle.transform.position = rectangleblack.transform.position;
            rectangleCorrect = true;
        }
        else
        {
            rectangle.transform.position = rectangleInitialPos;
        }
    }
    public void DropTriangle()
    {
        float Distance = Vector3.Distance(triangle.transform.position, triangleblack.transform.position);
        if (Distance < 50)
        {
            triangle.transform.position = triangleblack.transform.position;
            triangleCorrect = true;
        }
        else
        {
            triangle.transform.position = triangleInitialPos;
        }
    }
     void Update()
    {
        if (circleCorrect & diamondCorrect & hexagonCorrect & rectangleCorrect & triangleCorrect)
        {
            btnn.gameObject.SetActive(true);
            btn.gameObject.SetActive(true);
            
            
        }
    }

    
}
