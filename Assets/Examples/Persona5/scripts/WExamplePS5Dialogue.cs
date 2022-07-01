using System;
using com.cratesmith.widgets;
using UnityEngine;

public class WExamplePS5Dialogue : WidgetBehaviour
{
	public string				m_SpeakerName;

	[TextArea]
	public string[] m_DialogueLine = new[]
	{
		"We're no strangers to love",
		"You know the rules and so do I",
		"A full commitment's what I'm thinking of",
		"You wouldn't get this from any other guy",
		"I just wanna tell you how I'm feeling",
		"Gotta make you understand",
		"Never gonna give you up",
		"Never gonna let you down",
		"Never gonna run around and desert you",
		"Never gonna make you cry",
		"Never gonna say goodbye",
		"Never gonna tell a lie and hurt you",
		"We've known each other for so long",
		"Your heart's been aching, but",
		"You're too shy to say it",
		"Inside, we both know what's been going on",
		"We know the game and we're gonna play it",
		"And if you ask me how I'm feeling",
		"Don't tell me you're too blind to see",
		"Never gonna give you up",
		"Never gonna let you down",
		"Never gonna run around and desert you",
		"Never gonna make you cry",
		"Never gonna say goodbye",
		"Never gonna tell a lie and hurt you",
		"Never gonna give you up",
		"Never gonna let you down",
		"Never gonna run around and desert you",
		"Never gonna make you cry",
		"Never gonna say goodbye",
		"Never gonna tell a lie and hurt you",
		"(Ooh, give you up)",
		"(Ooh, give you up)",
		"Never gonna give, never gonna give",
		"(Give you up)",
		"Never gonna give, never gonna give",
		"(Give you up)",
		"We've known each other for so long",
		"Your heart's been aching, but",
		"You're too shy to say it",
		"Inside, we both know what's been going on",
		"We know the game and we're gonna play it",
		"I just wanna tell you how I'm feeling",
		"Gotta make you understand",
		"Never gonna give you up",
		"Never gonna let you down",
		"Never gonna run around and desert you",
		"Never gonna make you cry",
		"Never gonna say goodbye",
		"Never gonna tell a lie and hurt you",
		"Never gonna give you up",
		"Never gonna let you down",
		"Never gonna run around and desert you",
		"Never gonna make you cry",
		"Never gonna say goodbye",
		"Never gonna tell a lie and hurt you",
		"Never gonna give you up",
		"Never gonna let you down",
		"Never gonna run around and desert you",
		"Never gonna make you cry",
		"Never gonna say goodbye",
		"Never gonna tell a lie and hurt you",
	};
	
	public int                  m_CurrentLine;
	public WidgetPrefab<WText>  m_WTextName;
	public WidgetPrefab<WText>  m_WTextDialogue;
	public WidgetPrefab<WImage> m_WImageTextBox;
	public WidgetPrefab<WImage> m_WImagePortrait;

	protected override void OnRefresh(ref WidgetBuilder builder)
	
	{
		builder.Widget(m_WImagePortrait);

		builder.Widget(m_WImageTextBox);
		
		builder.Widget(m_WTextName)
				.State(new SText()
				{
					text = m_SpeakerName,
				});

		builder.Widget(m_WTextDialogue)
				.State(new SText()
				{
					text = m_CurrentLine>=0 && m_CurrentLine < m_DialogueLine.Length 
						? m_DialogueLine[m_CurrentLine]
						: ""
				});
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			m_CurrentLine = m_DialogueLine.Length > 0
				? (m_CurrentLine + 1) % m_DialogueLine.Length
				: 0;
			SetDirty();
		}
	}
}
