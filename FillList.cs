using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;

public partial class FillList : MarginContainer
{
	[Export] public string labelText;
	[Export] public PackedScene entryScene;
	[Export] public Array<string> entries {get; set;} = new Array<string>();

	[Export] public Control entryContainer;
	public override void _Ready()
	{
		GetNode<LabelSetter>("Label Setter").Update(labelText);
		foreach(string entry in entries)
		{
			LabelSetter newEntry = entryScene.Instantiate<LabelSetter>();
			newEntry.Update(entry);
			entryContainer.AddChild(newEntry);
		}
	}


}
