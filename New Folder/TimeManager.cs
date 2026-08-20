using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    
    public float currentTime;
    public float startTime;
    public Transform directionalLight;

    public TMP_Text _textim;

    bool deneme = true;

    public float dayTime = 20f;
    private float sunAngle;

    private void Start()
    {   
        directionalLight.rotation = Quaternion.Euler(0f, 0, 0f);
        
        if(startTime > 0)
        {
            Debug.Log("startTime calisiyor");

        }
        else
        {
            Debug.Log("startTime Calismiyort!");
        }

    }



    private void Update()
    {
        if (startTime > 0 && deneme)
        {
           
            currentTime += (24 / dayTime) * Time.deltaTime + startTime;
            deneme = false;
        }
        else
        {

           // bir sey yapmama gerek yok 
        }

        currentTime += (24 / dayTime) * Time.deltaTime;
        currentTime = Mathf.Repeat(currentTime, 24);

        //1 
        sunAngle = 360 / 24 * currentTime;


        if(currentTime >= 0f && currentTime <= 6  )
        {
            _textim.text = _enummim.Sunrise.ToString();
        }
        else if(currentTime >= 7f && currentTime <= 12)
        {
            _textim.text = _enummim.Noon.ToString();
        }
        else if(currentTime >= 13f && currentTime <=18f)
        {
            _textim.text = _enummim.Sunset.ToString();
        }
        else if(currentTime >= 19 && currentTime <= dayTime)
        {
            _textim.text = _enummim.Midnight.ToString();
        }


        //   Debug.Log(sunAngle);

        directionalLight.rotation = Quaternion.Euler(sunAngle, 0f, 0f);


        Debug.Log(currentTime + " " + "Euler.X  : " + directionalLight.rotation.x);
    }

 


}
enum _enummim
{
    Sunrise,
    Noon,
    Sunset,
    Midnight
  
        

}
