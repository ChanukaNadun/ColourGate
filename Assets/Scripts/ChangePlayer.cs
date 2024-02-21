using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public GameObject circle;
    public GameObject squre;
    public SpriteRenderer sq_SR;
    public SpriteRenderer cl_SR;
    public int count = 0;
    public Color[] passColor; //[Color.red, Color.green, Color.blue, Color.yellow]
    //int colorIndex;


    // Start is called before the first frame update
    void Start()
    {
        sq_SR = squre.GetComponent<SpriteRenderer>();
        cl_SR = circle.GetComponent<SpriteRenderer>();
        //cl_SR.enabled = true;
        //sq_SR.enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        //OnMouseDownCircle();
        //OnMouseDownSqure();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //cl_SR.enabled = true;

            count++;
            
            Debug.Log("Count"+count);
            //for(colorIndex = 0; colorIndex <= 4;colorIndex++)
            //{
            //    cl_SR.GetComponent<SpriteRenderer>().color = passColor[colorIndex];
            //    if (colorIndex == 4)
            //    {
            //        colorIndex= 0;

            //    }
            //    Debug.Log("Index" + colorIndex);
            //}
            //if (count % 2 == 1)
            //{
            //    cl_SR.enabled = false;
            //    sq_SR.enabled = true;
            //}
            //else
            //{
            //    sq_SR.enabled = false;
            //    cl_SR.enabled = true;
            //}
            if (count % 4 == 0)
            {
                cl_SR.GetComponent<SpriteRenderer>().color = passColor[0];
            }
            else if(count % 4 == 1) 
            {
                cl_SR.GetComponent<SpriteRenderer>().color = passColor[1];
            }
            else if (count % 4 == 2)
            {
                cl_SR.GetComponent<SpriteRenderer>().color = passColor[2];
            }
            else
            {
                cl_SR.GetComponent<SpriteRenderer>().color = passColor[3];
            }


        }
    }
    
   
    //public void OnMouseDownCircle()
    //{
    //    if (Input.GetKeyDown(KeyCode.Mouse0) && cl_SR.enabled == true)
    //    {
    //        cl_SR.enabled = false;
    //        sq_SR.enabled = true;
    //    }
    //}
    //public void OnMouseDownSqure()
    //{
    //    if (Input.GetKeyDown(KeyCode.Mouse0) && sq_SR.enabled == true)
    //    {
    //        sq_SR.enabled = false;
    //        cl_SR.enabled = true;
    //    }
    //}
}
