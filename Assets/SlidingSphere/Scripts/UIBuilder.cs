using TMPro;
using UnityEngine;

public class UIBuilder : MonoBehaviour
{
    [SerializeField]
    TMP_Text text;
    [SerializeField]
    RectTransform positionHolder;
    [SerializeField]
    Canvas parentCanvas;

    private void Start()
    {
        GameObject go = Instantiate(text.gameObject, positionHolder.transform.position, Quaternion.identity) as GameObject;
        go.transform.SetParent(parentCanvas.transform);
    }
}
