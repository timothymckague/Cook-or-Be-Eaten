using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnaceScriptJulian : MonoBehaviour, IInteractable
{
    public FridgeCanvasToggle fridgeCanvasToggle;


    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
        fridgeCanvasToggle.fridgeCanvasTrigger();
    }

    void Start()
    {
        fridgeCanvasToggle = GameObject.Find("FridgeCanvas").GetComponent<FridgeCanvasToggle>();
    }
}
//furnace
