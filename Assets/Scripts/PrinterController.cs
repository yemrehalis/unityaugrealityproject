using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrinterController : MonoBehaviour


{

    public Animator anim;
    public bool PrintOn;
    public GameObject UiPanel;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        PrintOn = false;
        UiPanel.gameObject.SetActive(false);
    }



   public void PrintStart()
    {
        UiPanel.gameObject.SetActive(true);

        if (PrintOn==false)

        {
            PrintOn = true;
            anim.Play("bed_animation_down");
          
        }
     
        


    }
    
}
