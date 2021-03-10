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
        deckList = new List<GameObject>();
        for (int cardIndex = 0; cardIndex < deckCount; cardIndex++)
        {
            GameObject deckCard = Instantiate(cardPrefab);
            deckList.Add(deckCard);
        }

        for (int i = 0; i < deckList.Count; i++) Debug.Log(deckList[i]);
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