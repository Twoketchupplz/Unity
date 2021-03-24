using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform _root;
    private Transform _initParent;
    private Hand _parentScript;
    private int _idxInHand;
    private Vector2 _currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        _root = transform.root;
        _initParent = transform.parent;
        _parentScript = _initParent.GetComponent<Hand>();
        Debug.Log("Card index is "+ _idxInHand);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetIdx(int idx)
    {
        _idxInHand = idx;
        transform.SetSiblingIndex(_idxInHand);
        Debug.Log("Set idx: " + transform.GetSiblingIndex());
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _idxInHand = transform.GetSiblingIndex();
        transform.SetParent(_root);
        _parentScript.ParentDummyCard(_idxInHand);
    }

    public void OnDrag(PointerEventData eventData)
    {
        _currentPosition = Input.mousePosition;
        transform.position = _currentPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _parentScript.UnparentDummyCard();
        if (RectTransformUtility.RectangleContainsScreenPoint(_initParent.GetComponent<RectTransform>(), _currentPosition))
        {
            transform.SetParent(_initParent);
            transform.SetSiblingIndex(_idxInHand);
        }
        // 그렇지 않다면 이 오브젝트를 Destroy한다.
        else
        {
            Destroy(gameObject);
            // Todo index의 파괴 여부는 결정짓지 않아도 무방한가?
        }
    }

}