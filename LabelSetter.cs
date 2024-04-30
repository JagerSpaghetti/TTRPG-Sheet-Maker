using Godot;
using System;

public partial class LabelSetter : Node
{
	[Export] public string labelText;
	[Export] public Label label;
	public override void _Ready()
	{
		Update();
	}

	public void Update()
	{
		label.Text = labelText;
	}
	public void Update(string text)
	{
		labelText = text;
		Update();
	}

}
