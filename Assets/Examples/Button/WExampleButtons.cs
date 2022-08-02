using com.cratesmith.widgets;
using UnityEngine;

public class WExampleButtons : WidgetBehaviour
{
    [SerializeField] WidgetPrefab<WVerticalBasicLayout> m_VerticalLayout;
    [SerializeField] WidgetPrefab<WButton>              m_Button;
    void Update()
    {
        SetDirty();
    }
    
    protected override void OnRefresh(ref WidgetBuilder builder)
    {
        using var vertical = builder.Widget(m_VerticalLayout).BeginChildren();
        for (int i = 0; i < 3; i++)
        {
            vertical.Widget(m_Button);
        }
    }
}
