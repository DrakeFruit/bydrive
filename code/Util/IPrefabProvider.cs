﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bydrive;

public interface IPrefabProvider
{
	public PrefabFile Prefab { get; }
}
