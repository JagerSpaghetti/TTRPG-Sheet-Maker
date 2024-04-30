using Godot;
using System;

public partial class AbilityScore : MarginContainer
{
	[Export] public string abilityScoreLabelText;

	[Export] public Label abilityScoreLabel;
	public override void _Ready()
	{
		abilityScoreLabel.Text = abilityScoreLabelText;
	}

	public override void _Process(double delta)
	{

	}
}
