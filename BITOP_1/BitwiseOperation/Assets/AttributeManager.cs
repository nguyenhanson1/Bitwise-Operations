using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class AttributeManager : MonoBehaviour
{
    public Text attributeDisplay;
    public static int MAGIC = 16;
    public static int INTELLIGENCE = 8;
    public static int CHARISMA = 4;
    public static int FLY = 2;
    public static int INVISIBLE = 1;
    int attributes = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Magic")
        {
            attributes |= MAGIC;
        }
        if (other.gameObject.tag == "Intelligence")
        {
            attributes |= INTELLIGENCE;
        }
        if (other.gameObject.tag == "Charisma")
        {
            attributes |= CHARISMA;
        }
        if (other.gameObject.tag == "Fly")
        {
            attributes |= FLY;
        }
        if (other.gameObject.tag == "Invisible")
        {
            attributes |= INVISIBLE;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8,'0');
    }
       
}
