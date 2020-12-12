using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{

    public TabGroup tabGroup;

    public Image background;

    public UnityEvent onTabSelected;
    public UnityEvent onTabDeselected;

    public AudioSource click;

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
        click.Play();
        LeanTween.scale(gameObject, new Vector3(1.08f, 1.08f, 1.08f), 0.3f).setDelay(0f).setEaseOutBounce();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OnTabExit(this);
    }

    void Start()
    {
        background = GetComponent<Image>();
        tabGroup.Subscribe(this);

    }

    public void OnEnable()
    {
        transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), 0.5f).setDelay(0f).setEaseOutBounce();
    }

    public void OnDisable()
    {
        LeanTween.scale(gameObject, new Vector3(0f, 0f, 0f), 0.5f).setDelay(0f).setEaseOutBounce();
    }

    public void Select()
    {
        if (onTabSelected != null)
        {
            onTabSelected.Invoke();
        }
    }

    public void Deselect()
    {
            if (onTabDeselected != null)
            {
                onTabDeselected.Invoke();
            }
    }

}
