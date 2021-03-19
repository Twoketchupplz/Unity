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
    private int _initIdx;
    private Vector2 _currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        _root = transform.root;
        _initParent = transform.parent;
        _parentScript = _initParent.GetComponent<Hand>();
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
        _parentScript.ParentDummyCard(_initIdx);
        
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
            transform.SetSiblingIndex(_initIdx);
        }
        // 그렇지 않다면 이 오브젝트를 Destroy한다.
        else
        {
            Destroy(gameObject);
        }
        Debug.Log("init Parent: ", _initParent);
        // 아무래도 콜백 함수가 끝날 때까지 다른 콜백함수가 끼어들 수 없는듯하다.
        // 그리고 자식 오브젝트가 부모 오브젝트의 콜백함수를 사용하는듯?
        // GetComponentInParent<Hand>().UnparentDummyCard(transform);
    }
}