using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2 : MonoBehaviour
{
    public GameObject beans, carrot, cucumbers, eggplant, lettuce, beansblack, carrotblack, cucumbersblack, eggplantblack, lettuceblack;


    Vector2 beansInitialPos, carrotInitialPos, cucumbersInitialPos, eggplantInitialPos, lettuceInitialPos;

    bool beansCorrect, carrotCorrect, cucumbersCorrect, eggplantCorrect, lettuceCorrect = false;

    public Button btn;
    public Button btnn;

    void Start()
    {
        beansInitialPos = beans.transform.position;
        carrotInitialPos = carrot.transform.position;
        cucumbersInitialPos = cucumbers.transform.position;
        eggplantInitialPos = eggplant.transform.position;
        lettuceInitialPos = lettuce.transform.position;
    }
    public void DragBeans()
    {
        beans.transform.position = Input.mousePosition;
    }
    public void DragCarrot()
    {
        carrot.transform.position = Input.mousePosition;
    }
    public void DragCucumbers()
    {
        cucumbers.transform.position = Input.mousePosition;
    }
    public void DragEggplant()
    {
        eggplant.transform.position = Input.mousePosition;
    }
    public void DragLettuce()
    {
        lettuce.transform.position = Input.mousePosition;
    }


    public void DropBeans()
    {
        float Distance = Vector3.Distance(beans.transform.position, beansblack.transform.position);
        if (Distance < 50)
        {
            beans.transform.position = beansblack.transform.position;
            beansCorrect = true;
        }
        else
        {
            beans.transform.position = beansInitialPos;
        }
    }
    public void DropCarrot()
    {
        float Distance = Vector3.Distance(carrot.transform.position, carrotblack.transform.position);
        if (Distance < 50)
        {
            carrot.transform.position = carrotblack.transform.position;
            carrotCorrect = true;
        }
        else
        {
            carrot.transform.position = carrotInitialPos;
        }

    }
    public void DropCucumbers()
    {
        float Distance = Vector3.Distance(cucumbers.transform.position, cucumbersblack.transform.position);
        if (Distance < 50)
        {
            cucumbers.transform.position = cucumbersblack.transform.position;
            cucumbersCorrect = true;
        }
        else
        {
            cucumbers.transform.position = cucumbersInitialPos;
        }
    }
    public void DropEggplant()
    {
        float Distance = Vector3.Distance(eggplant.transform.position, eggplantblack.transform.position);
        if (Distance < 50)
        {
            eggplant.transform.position = eggplantblack.transform.position;
            eggplantCorrect = true;
        }
        else
        {
            eggplant.transform.position = eggplantInitialPos;
        }
    }
    public void DropLettuce()
    {
        float Distance = Vector3.Distance(lettuce.transform.position, lettuceblack.transform.position);
        if (Distance < 50)
        {
            lettuce.transform.position = lettuceblack.transform.position;
            lettuceCorrect = true;
        }
        else
        {
            lettuce.transform.position = lettuceInitialPos;
        }
    }
    void Update()
    {
        if (beansCorrect & carrotCorrect & cucumbersCorrect & eggplantCorrect & lettuceCorrect)
        {
            btn.gameObject.SetActive(true);
            btnn.gameObject.SetActive(true);
         

        }
    }

}
