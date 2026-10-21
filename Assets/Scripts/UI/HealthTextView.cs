using UnityEngine;
using TMPro;

public class HealthTextView : HealthView
{
    [SerializeField] private TMP_Text _text;

    protected override void Refresh(float current, float max)
    {
        _text.text = $"{current}/{max}";
    }
}
