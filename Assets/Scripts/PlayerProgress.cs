using UnityEngine;
using TMPro;

public class PlayerProgress : MonoBehaviour
{
    private float _experienceCurrentValue = 0;
    private float _experienceTargetValue = 100;
    private int _levelValue = 1;

    public RectTransform experienceValueRectTransform;
    public TextMeshProUGUI levelValueTMP;

    private void Start()
    {
        DrawUI();
    }

    public void AddExperience(float value)
    {
        _experienceCurrentValue += value;

        if (_experienceCurrentValue >= _experienceTargetValue)
        {
            _levelValue += 1;
            _experienceCurrentValue = 0;
        }
        DrawUI();
    }

    private void DrawUI()
    {
        experienceValueRectTransform.anchorMax = new Vector2(_experienceCurrentValue/ _experienceTargetValue, 1);
        levelValueTMP.text = _levelValue.ToString();
    }
}
