using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 initialPosition, beginPosition, currentPosition;
    private int idx;
    public GameObject DummyCard;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        idx = transform.GetSiblingIndex();
        Debug.Log("Card index is "+ idx);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        currentPosition = Input.mousePosition;
        transform.position = currentPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End");
    }
}