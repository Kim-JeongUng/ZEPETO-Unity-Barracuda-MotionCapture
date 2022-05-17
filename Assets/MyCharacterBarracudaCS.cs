using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterBarracudaCS : MonoBehaviour
{
    public CharacterController player;
    public VNectBarracudaRunner BarracudaRunner;
    public GameObject player_;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FindCharacter()
    {
        if (player = GameObject.FindObjectOfType<CharacterController>())
        {
            player_ = player.transform.GetChild(0).gameObject;
            SetCharacter();
            SetBarracuda();
        }
    }
    public void SetCharacter()
    {
        player_.AddComponent<VNectModel>();
        player_.GetComponent<VNectModel>().ModelObject = player_;
        player_.GetComponent<VNectModel>().Nose = GameObject.Find("nose");
    }
    public void SetBarracuda()
    {
        BarracudaRunner.VNectModel = player_.GetComponent<VNectModel>();
        Debug.Log("Barracuda Set complete");
        SetCharacterAnim();
    }
    public void SetCharacterAnim()
    {
        player.GetComponent<CharacterController>().enabled = false;
        player_.GetComponent<Animator>().enabled = false;

    }
    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            FindCharacter();
        }
    }
}
