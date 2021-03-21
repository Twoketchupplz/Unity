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
    private Hand _parentScript;
    private int _idxInHand;
    private Vector2 _currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        _root = transform.root;
        _initParent = transform.parent;
        _parentScript = _initParent.GetComponent<Hand>();
        _idxInHand = transform.GetSiblingIndex();
        Debug.Log("Card index is "+ _idxInHand);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetIndex()
    {
        _idxInHand = transform.GetSiblingIndex();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin, init idx: " + _idxInHand);
        transform.SetParent(_root);
        _parentScript.ParentDummyCard(_idxInHand);
        // GetComponentInParent<Hand>().ParentDummyCard(cardIdx);
    }

    public void OnDrag(PointerEventData eventData)
    {
        _currentPosition = Input.mousePosition;
        transform.position = _currentPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _parentScript.UnparentDummyCard();
        // 현재 마우스 위치가 초기 부모(hand)의 RectTransform 안에 있다면 오브젝트가 되돌아가 가고
        if (RectTransformUtility.RectangleContainsScreenPoint(_initParent.GetComponent<RectTransform>(), _currentPosition))
        {
            transform.SetParent(_initParent);
            transform.SetSiblingIndex(_idxInHand);
        }
        // 그렇지 않다면 이 오브젝트를 Destroy한다.
        else
        {
            Destroy(gameObject);
            // Todo index의 파괴 여부는 별도이다.
            // transform.DetachChildren();
            // _parentScript.SetCardIndex();
        }
    }
}