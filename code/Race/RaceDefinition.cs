﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bydrive;

/// <summary>
/// Information about the current race
/// </summary>
[GameResource("Race Definition", "race", "Stores information about a specific race")]
[Icon("timer")]
public class RaceDefinition : GameResource
{
	public string Name { get; set; }
	public string Group { get; set; }
	public bool Hidden { get; set; }
	public SceneFile Scene { get; set; }
}
