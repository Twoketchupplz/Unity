using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Deck : MonoBehaviour, IPointerClickHandler
{
    public int deckCount;
    private List<GameObject> deckList;
    private Transform root;
    public GameObject cardPrefab;

    private void Awake()
    {
        root = transform.root;
    }

    void Start()
    {

    }

    void Update()
    {
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicked {deck}");
        root.BroadcastMessage("Draw", transform, SendMessageOptions.DontRequireReceiver);
    }
}