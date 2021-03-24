using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Deck : MonoBehaviour, IPointerClickHandler
{
    public int DeckSize;
    public GameObject handObj;

    private int _drawCtr;
    private List<GameObject> _deckList;
    private Transform _root;
    private Hand handScript;

    private void Awake()
    {
        _root = transform.root;
        handScript = handObj.GetComponent<Hand>();
        _drawCtr = 0;
        // _root.GetChild(2)
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
        // _root.BroadcastMessage("Draw", transform, SendMessageOptions.DontRequireReceiver);
        // 위 BroadcastMessage나 SendMessage 함수는 비용이 너무 크다. 원하는 함수가 어디있는지 알고있으므로 아래와 같이 바꿔준다.
        handScript.Draw(_drawCtr++);
    }
}