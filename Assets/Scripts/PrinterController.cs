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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void PrintStart()
    {
        if (PrintOn==false)

        {
            PrintOn = true;
            anim.Play("bed_animation_down");
            PrintOn = false;
            UiPanel.gameObject.SetActive(true);

        }
        


    }
    
}
