﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand : MonoBehaviour
{
    public GameObject childCard;
    public GameObject prefabDummy;

    [HideInInspector]
    public int handLimit;

    private Transform _root;
    private GameObject _invisibleCard;
    private int _ivCardIdx;
    // Start is called before the first frame update
    void Start()
    {
        _root = transform.root;
        _invisibleCard = Instantiate(prefabDummy, _root, true);
        _invisibleCard.transform.localScale = Vector3.one;
        Debug.Log("Hand root: ", _root);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Draw(int cardIdx)
    {
        if (transform.childCount < handLimit)
        {
            GameObject childCard = Instantiate(this.childCard, transform, true);
            childCard.GetComponent<Card>().SetIdx(cardIdx);
            childCard.transform.localScale = Vector3.one;
        }
    }

    public void SwapCard(GameObject dest, GameObject src)
    {
        
    }

    public void ParentDummyCard(int cardIndex)
    {
        _ivCardIdx = cardIndex;
        _invisibleCard.transform.SetParent(transform);
        // transform.setParent()와 transform.parent의 차이
        // https://answers.unity.com/questions/1153512/transformparent-vs-transformsetparent.html ,https://kukuta.tistory.com/177
        _invisibleCard.transform.localScale = Vector3.one;
        _invisibleCard.transform.SetSiblingIndex(_ivCardIdx); //이부분에서 idx를 앞에서부터 세기 떄문에 문제가 발생함
    }

    public void UnparentDummyCard()
    {
        _invisibleCard.transform.SetParent(_root);
    }
    //이렇게 말고 Swap하는 형태로 하나의 함수로 만들 수 있지 않을까

}