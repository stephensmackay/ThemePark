﻿using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using TMPro;
using UnityEngine;

public class PopUpFiller : MonoBehaviour
{

    public POISO info;
    public GameObject textPrefab, spritePrefab, buttonPrefab;
    private GameObject _name, _description, _icon, _button;
    
    // Start is called before the first frame update
    void Start()
    {
        _name = Instantiate(textPrefab, transform);
        
        _name.GetComponent<RectTransform>().localPosition = new Vector3(.25f,.1f,0);
        _name.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);
        _name.GetComponent<TextMeshPro>().text = info.Name;
        _name.GetComponent<TextMeshPro>().fontSize = 3;
        _name.GetComponent<TextMeshPro>().sortingOrder = 5;

        
        _description = Instantiate(textPrefab, transform);
        
        _description.GetComponent<RectTransform>().localPosition = new Vector3(0,-.2f,0);
        _description.GetComponent<TextMeshPro>().text = info.description;
        _description.GetComponent<TextMeshPro>().fontSize = 1.75f;
        _name.GetComponent<TextMeshPro>().sortingOrder = 5;


        _icon = Instantiate(spritePrefab, transform);

        _icon.GetComponent<SpriteRenderer>().sprite = info.icon;
        _icon.GetComponent<SpriteRenderer>().sortingOrder = 5;
        _icon.GetComponent<SpriteRenderer>().color = Color.black;
        _icon.transform.localPosition = new Vector3(-1.3f, .3f, 0);


        _button = Instantiate(buttonPrefab, transform);

        _button.transform.localPosition = new Vector3(1, -.3f, 0);
        _button.transform.localScale = Vector3.one * .25f;
        _button.GetComponent<SetNavigation>().info = info;
    }
}
