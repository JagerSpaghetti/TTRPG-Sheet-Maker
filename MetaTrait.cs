using Godot;
using System;

public partial class MetaTrait : MarginContainer
{
	[Export] public string traitLabelText;
	
	[Export] public Label traitLabel;
	


	public override void _Ready()
	{
		traitLabel.Text = traitLabelText;
	}

	public override void _Process(double delta)
	{

	}

	
}
