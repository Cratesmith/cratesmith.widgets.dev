using com.cratesmith.widgets;
using UnityEngine;

public class WExampleButtons : WidgetBehaviour
{
    [SerializeField] WidgetPrefab<WVerticalBasicLayout> m_VerticalLayout;
    [SerializeField] WidgetPrefab<WButton>              m_Button;
    [SerializeField] WidgetPrefab<WTextButton>          m_TextButton;

    protected override void OnRefresh(ref WidgetBuilder builder)
    {
        using var vertical = builder.Widget(m_VerticalLayout).BeginChildren();
        for (int i = 0; i < 3; i++)
        {
            vertical.Widget(m_Button, i.AsContextId()).Event(out EClicked clicked).Event<EHovered>();
            if (clicked)
            {
                Debug.Log($"Clicked button {i} frame {clicked.frame}");
                
                vertical.Widget<WText>().State(new SText()
                {
                    text = "hello!"
                });
            }
        }
        
        for (int i = 3; i < 6; i++)
        {
            vertical.Widget(m_TextButton,i.AsContextId()).State(new STextButton()
            {
                textState = new SText()
                {
                    text = $"Textbutton {i}"
                }
            }).Event(out EClicked clicked).Event<EHovered>();
            if (clicked)
            {
                Debug.Log($"Clicked text button {i} frame {clicked.frame}");
                
                vertical.Widget<WText>().State(new SText()
                {
                    text = "hello!"
                });
            }
        }
    }
}
