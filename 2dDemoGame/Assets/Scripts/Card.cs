using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // public GameObject hand;
    private Transform _root;
    private Transform _initParent;
    private int _initIdx;
    private Vector2 _currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        _root = transform.root;
        _initParent = transform.parent;
        _initIdx = transform.GetSiblingIndex();
        Debug.Log("Card index is "+ _initIdx);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin");
        transform.SetParent(_root);
        // GetComponentInParent<Hand>().ParentDummyCard(cardIdx);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        _currentPosition = Input.mousePosition;
        transform.position = _currentPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(_initParent);
        transform.SetSiblingIndex(_initIdx);
        Debug.Log("End");
        // GetComponentInParent<Hand>().UnparentDummyCard(transform);
    }
}