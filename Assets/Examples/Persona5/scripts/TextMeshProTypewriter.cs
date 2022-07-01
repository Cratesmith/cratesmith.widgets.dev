using TMPro;
using UnityEngine;

[DisallowMultipleComponent]
public class TextMeshProTypewriter : MonoBehaviour
{
    public float m_Speed = 5f;
    TMP_Text     m_Text;
    string       m_LastText;
    float        m_Time;

    void Awake()
    {
        m_Text = GetComponent<TMP_Text>();
    }
    
    void Update()
    {
        if (m_Text.text != m_LastText)
        {
            m_Time = 0;
            m_LastText = m_Text.text;
        } else
        {
            m_Time += Time.unscaledDeltaTime;
        }

        var newChars = (int)(m_Time * m_Speed);
        if (newChars != m_Text.maxVisibleCharacters)
        {
            m_Text.firstVisibleCharacter = 0;
            m_Text.maxVisibleCharacters = newChars;
        }
    }
}
